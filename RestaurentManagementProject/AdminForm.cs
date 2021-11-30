using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;
using System.Data.SqlClient;

namespace RestaurentManagementProject
{
    public partial class AdminForm : Form
    {
        private DataTable foodTable;
        private List<Role> _list_roles;
        public AdminForm()
        {
            InitializeComponent();
        }
        private void LoadCategory()
        {
            CategoryBL categoryBL = new CategoryBL();
            DataTable dt = categoryBL.GetIDAndName();

            cbb_category.DataSource = dt;
            cbb_category.DisplayMember = "Name";
            cbb_category.ValueMember = "ID";
        }

        private void cbb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_category.SelectedIndex == -1) return;

            FoodBL foodBL = new FoodBL();
            
            int CategoryID = 0;
            if (cbb_category.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbb_category.SelectedValue as DataRowView;
                CategoryID = (int)rowView["ID"];
            }
            else
            {
                CategoryID = (int)cbb_category.SelectedValue;
            }

            DataTable dt = foodBL.GetFoodByCategoryID(CategoryID);

            dgv_foods.DataSource = dt;
            foodTable = dt;

            lbl_quantily.Text = dt.Rows.Count.ToString();
            lbl_category_name.Text = cbb_category.Text;

            dgv_foods.Columns[0].HeaderText = "Mã số";
            dgv_foods.Columns[1].HeaderText = "Tên món ăn";
            dgv_foods.Columns[1].Width = 150;
            dgv_foods.Columns[2].HeaderText = "Đơn vị";
            dgv_foods.Columns[3].HeaderText = "Mã số nhóm";
            dgv_foods.Columns[4].HeaderText = "Đơn giá";
            dgv_foods.Columns[5].HeaderText = "Mô tả";

            dgv_foods.RowHeadersVisible = false;
            dgv_foods.AllowUserToAddRows = false;
        }

        private void tsm_caculater_quantily_Click(object sender, EventArgs e)
        {
            BillDetailBL billDetailBL = new BillDetailBL();

            if (dgv_foods.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_foods.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                int foodID = (int)rowView["ID"];


                string result = billDetailBL.SumQuantily(foodID);
                if (result == "") result = "0";
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là " + result + " " + rowView["Unit"]);
            }
        }

        private void txt_search_by_name_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;
            string filterExpression = "Name like '%" + txt_search_by_name.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowState = DataViewRowState.OriginalRows;
            DataView dataView = new DataView(foodTable, filterExpression, sortExpression, rowState);
            dgv_foods.DataSource = dataView;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //Tabpage1
            LoadCategory();
            //tabpage2
            LoadDiningTabelData();
            //Tabpage4
            LoadData();
            LoadRoleAccountToCbb();
        }

        private void tsm_add_food_Click(object sender, EventArgs e)
        {
            FormInfoFood foodInfoForm = new FormInfoFood();
            foodInfoForm.FormClosed += new FormClosedEventHandler(foodForm_FormClose);
            foodInfoForm.Show(this);
        }

        private void tsm_update_food_Click(object sender, EventArgs e)
        {
            if (dgv_foods.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_foods.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                FormInfoFood foodInfoForm = new FormInfoFood();
                foodInfoForm.FormClosed += new FormClosedEventHandler(foodForm_FormClose);

                foodInfoForm.Show(this);
                foodInfoForm.DisplayFoodInfo(rowView);
            }
        }
        private void foodForm_FormClose(object sender, FormClosedEventArgs e)
        {
            int index = cbb_category.SelectedIndex;
            cbb_category.SelectedIndex = -1;

            LoadCategory();
            cbb_category.SelectedIndex = index;
        }

        private void LoadRoleAccountToCbb()
        {
            RoleBL roleBL = new RoleBL();

            _list_roles = roleBL.GetAll();
            cbb_Group.DataSource = _list_roles;
            cbb_Group.BindingContext = new BindingContext();
            cbb_Group.DisplayMember = "RoleName";
            cbb_Group.ValueMember = "ID";
            cbb_Group.SelectedIndex = -1;
            cbb_role.DataSource = _list_roles;
            //cbb_role.BindingContext = new BindingContext();
            cbb_role.DisplayMember = "RoleName";
            cbb_role.ValueMember = "ID";
            cbb_role.SelectedIndex = -1;
        }
        private void LoadData()
        {
            AccountBL accountBL = new AccountBL();
            DataTable dt = accountBL.GetDataToLoad();
            dgv_Accounts.DataSource = dt;
            
            SetHeaderTextGDV();
            this.dgv_Accounts.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dgv_Accounts.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dgv_Accounts.RowHeadersVisible = false;
            this.dgv_Accounts.AllowUserToAddRows = false;
        }
        private void SetHeaderTextGDV()
        {
            dgv_Accounts.Columns[0].HeaderText = "Tên tài khoản";
            dgv_Accounts.Columns[1].HeaderText = "Tên đầy đủ";
            dgv_Accounts.Columns[1].Width = 150;
            dgv_Accounts.Columns[2].HeaderText = "Email";
            dgv_Accounts.Columns[3].HeaderText = "Số điện thoại";
            // dgv_Accounts.Columns[4].HeaderText = "Ngày tạo tài khoản";
            dgv_Accounts.Columns[4].HeaderText = "Quyền";
            dgv_Accounts.Columns[5].HeaderText = "Trạng thái";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //string query = "";

            //sqlCommand.Parameters.Add("@status", SqlDbType.Bit).Value = -1;
            //sqlCommand.Parameters.Add("@roleid", SqlDbType.Int).Value = -1;
            //if (cbb_Group.Text != "" && cbb_Status.Text != "")
            //{
            //    sqlCommand.Parameters["@status"].Value = cbb_Status.Text == "Actived" ? 1 : 0;
            //    sqlCommand.Parameters["@roleid"].Value = int.Parse(_list_roles.Find(s => s.RoleName == cbb_Group.Text).ID);

            //    query = "select a.AccoutName, a.FullName, a.Email, a.Tell, r.RoleName, ra.Actived " +
            //    "from Role r, Account a, RoleAccount ra " +
            //    "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName and " +
            //    "ra.Actived = @status and r.ID =@roleid";

            //}
            //else if (cbb_Group.Text == "" && cbb_Status.Text != "")
            //{
            //    sqlCommand.Parameters["@status"].Value = cbb_Status.Text == "Actived" ? 1 : 0;
            //    query = "select a.AccoutName, a.FullName, a.Email, a.Tell, r.RoleName, ra.Actived " +
            //    "from Role r, Account a, RoleAccount ra " +
            //    "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName and " +
            //    "ra.Actived = @status";
            //}
            //else if (cbb_Group.Text != "" && cbb_Status.Text == "")
            //{
            //    sqlCommand.Parameters["@roleid"].Value = int.Parse(_list_roles.Find(s => s.RoleName == cbb_Group.Text).ID);
            //    query = "select a.AccoutName, a.FullName, a.Email, a.Tell, r.RoleName, ra.Actived " +
            //    "from Role r, Account a, RoleAccount ra " +
            //    "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName and " +
            //    " r.ID =@roleid";
            //}
            //else
            //{
            //    query = "select a.AccoutName, a.FullName, a.Email, a.Tell, r.RoleName, ra.Actived " +
            //    "from Role r, Account a, RoleAccount ra " +
            //    "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName";
            //}
            //sqlCommand.CommandText = query;
            //sqlConnection.Open();

            //SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            //DataTable dt = new DataTable("Accounts");
            //da.Fill(dt);
            //dgv_Accounts.DataSource = dt;

            //sqlConnection.Close();
            //sqlConnection.Dispose();
            //da.Dispose();
            //SetHeaderTextGDV();
        }

        private void dgv_Accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Accounts.SelectedRows.Count > 0)
            {
                txt_account_name.Text = dgv_Accounts.SelectedRows[0].Cells[0].Value.ToString();
                txt_fullname.Text = dgv_Accounts.SelectedRows[0].Cells[1].Value.ToString();
                txt_email.Text = dgv_Accounts.SelectedRows[0].Cells[2].Value.ToString();
                txt_tell.Text = dgv_Accounts.SelectedRows[0].Cells[3].Value.ToString();
                cbb_role.Text = dgv_Accounts.SelectedRows[0].Cells[4].Value.ToString();
                cbb_stt.Text = dgv_Accounts.SelectedRows[0].Cells[5].Value.ToString() == "True" ? "Actived" : "Nonactived";
            }
        }

        private void btn_Clear_click(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void ResetControls()
        {
            txt_account_name.Text = "";
            txt_fullname.Text = "";
            txt_email.Text = "";
            txt_tell.Text = "";
            cbb_role.Text = "";
            cbb_stt.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            AccountBL accountBL = new AccountBL();
            
            string role_id = _list_roles.Find(s => s.RoleName == cbb_role.Text).ID.ToString();
            string stt = cbb_stt.Text == "Actived" ? "1" : "0";

            Account account = new Account();
            account.AccountName = txt_account_name.Text;
            account.FullName = txt_fullname.Text;
            account.Email = txt_email.Text;
            account.Tell = txt_tell.Text;

            int num = accountBL.Insert(account, role_id, stt);

            LoadData();
            ResetControls();

        }

        private void tsm_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_Accounts.SelectedRows.Count > 0)
            {
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                string roleID = _list_roles.Find(s => s.RoleName == dgv_Accounts.SelectedRows[0].Cells[4].Value.ToString()).ID.ToString();

                sqlCommand.CommandText = "Update RoleAccount set Actived = 'false' where AccountName =  @AccountName and RoleID = @RoleId";

                sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = txt_account_name.Text;
                sqlCommand.Parameters.Add("@RoleId", SqlDbType.Int).Value = int.Parse(roleID);
                sqlConnection.Open();


                int num = sqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    LoadData();
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công!");
                }
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        private void tsm_viewDetail_Click(object sender, EventArgs e)
        {
            //RoleAccountForm roleAccountForm = new RoleAccountForm();
            //roleAccountForm.Show();
            //roleAccountForm.LoadData(txt_account_name.Text);
        }

        private void btn_Change_Pasword_Click(object sender, EventArgs e)
        {
            //string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = "select Password from Account where AccoutName = @AccountName";
            //sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = txt_account_name.Text;
            //sqlConnection.Open();
            //string pass = sqlCommand.ExecuteScalar().ToString();
            //ChangePwForm changePwForm = new ChangePwForm(txt_account_name.Text, pass);

            //if (changePwForm.ShowDialog() == DialogResult.OK)
            //{
            //    button1.PerformClick();
            //}

        }

        private void tsm_view_catalogs_Click(object sender, EventArgs e)
        {
            //if (dgv_Accounts.SelectedRows.Count > 0)
            //{
            //    AccountCatelogs accountCatelogs = new AccountCatelogs();
            //    accountCatelogs.Show();
            //    accountCatelogs.LoadDataByAccountName(dgv_Accounts.SelectedRows[0].Cells[0].Value.ToString());
            //}
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            BillBL billBL = new BillBL();
            DataTable dt = billBL.GetByDate(dtp_date.Value.Date.ToString());
            dgv_bills.DataSource = dt;

            dgv_bills.Columns[0].HeaderText = "Mã hóa đơn";
            dgv_bills.Columns[1].HeaderText = "Tên hóa đơn";
            dgv_bills.Columns[2].HeaderText = "Mã bàn";
            dgv_bills.Columns[3].HeaderText = "Trị giá hóa đơn";
            dgv_bills.Columns[4].HeaderText = "Giảm giá %";
            dgv_bills.Columns[5].HeaderText = "Thuế";
            dgv_bills.Columns[6].HeaderText = "Đã thanh toán";
            dgv_bills.Columns[7].HeaderText = "Ngày thanh toán";
            dgv_bills.Columns[8].HeaderText = "Tên tài khoản";

            if (dt.Rows.Count > 0)
            {
                lbl_sum.Text = billBL.GetSalary(dtp_date.Value.Date.ToString()).ToString();
            }

            //sqlConnection.Close();
            //sqlConnection.Dispose();
            this.dgv_bills.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dgv_bills.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dgv_bills.RowHeadersVisible = false;
            this.dgv_bills.AllowUserToAddRows = false;
        }

        private void dgv_bills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bills.SelectedRows.Count > 0)
            {
                BillDetailForm billDetail = new BillDetailForm();
                billDetail.Show();
                billDetail.LoadFoods(int.Parse(dgv_bills.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void btn_save_table_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                DiningTable diningTable = new DiningTable();
                diningTable.ID = 0;
                diningTable.Name = txt_name.Text;
                diningTable.Status = 0;
                diningTable.Capacity = int.Parse(txt_Capacity.Text);

                DiningTableBL diningTableBL = new DiningTableBL();
                diningTableBL.Insert(diningTable);
            }
            else
            {
                DiningTable diningTable = new DiningTable();
                diningTable.ID = int.Parse(txt_id.Text);
                diningTable.Name = txt_name.Text;
                diningTable.Status = 0;
                diningTable.Capacity = int.Parse(txt_Capacity.Text);

                DiningTableBL diningTableBL = new DiningTableBL();
                diningTableBL.Update(diningTable);
            }
            LoadDiningTabelData();
        }

        private void btn_remove_table_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_table_Click(object sender, EventArgs e)
        {
            ResetTableControlls();
        }

        private void btn_view_bill_table_Click(object sender, EventArgs e)
        {
            BillForm billForm = new BillForm(txt_id.Text);
            billForm.Show();
        }
        private void LoadDiningTabelData()
        {
            DiningTableBL diningTableBL = new DiningTableBL();
            List<DiningTable> diningTables = diningTableBL.GetAll();
            dgv_Tabels.DataSource = diningTables;

            dgv_Tabels.Columns[0].HeaderText = "Mã bàn";
            dgv_Tabels.Columns[1].HeaderText = "Tên bàn";
            dgv_Tabels.Columns[2].HeaderText = "Trạng thái";
            dgv_Tabels.Columns[3].HeaderText = "Số chổ ngồi";

            this.dgv_Tabels.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dgv_Tabels.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dgv_Tabels.RowHeadersVisible = false;
            this.dgv_Tabels.AllowUserToAddRows = false;
        }

        private void dgv_Tabels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Tabels.SelectedRows.Count > 0)
            {
                txt_id.Text = dgv_Tabels.SelectedRows[0].Cells[0].Value.ToString();
                txt_name.Text = dgv_Tabels.SelectedRows[0].Cells[1].Value.ToString();
                txt_Capacity.Text = dgv_Tabels.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void ResetTableControlls()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_Capacity.Text = "";
        }

        private void dgv_Tabels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
