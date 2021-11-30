using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace RestaurentManagementProject
{
    public partial class Form1 : Form
    {
        private int _current_table_id = -1;
        private string _current_account_name;
        private int _prv_table_id;
        private int _curr_bill_id = -1;
        private string _current_table_name;

        private List<Category> _categories;
        private List<Food> _foods;
        private List<DiningTable> _diningTables;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm._Admin) tsm_Admin.Enabled = true;
            else tsm_Admin.Enabled = false;
            _current_account_name = loginForm._Current_AccountName;
            //_current_account_name = "lgCongcn";
            this.Text = "Phiên đăng nhập của tài khoản: " + loginForm._Current_AccountName;
            //this.Text = "Phiên đăng nhập của tài khoản: " + _current_account_name;
            LoadDinningTable();
            InitView();
        }
        private void InitView()
        {
            CategoryBL categoryBL = new CategoryBL();
            _categories = categoryBL.GetAll();
            cbb_category.DataSource = _categories;
            cbb_category.DisplayMember = "Name";
            cbb_category.ValueMember = "ID";

            DiningTableBL diningTableBL = new DiningTableBL();
            _diningTables = diningTableBL.GetAll();
            cbb_dinning_table.BindingContext = new BindingContext();
            cbb_dinning_table.DataSource = _diningTables;
            cbb_dinning_table.DisplayMember = "Name";
            cbb_dinning_table.ValueMember = "ID";
            
        }
        private void LoadDinningTable()
        {
            fpn_tables.Controls.Clear();
            DiningTableBL diningTableBL = new DiningTableBL();
            _diningTables=diningTableBL.GetAll();
            foreach(var item in _diningTables)
            {
                CreateButtonTable(item.ID.ToString(), item.Name, item.Status.ToString(), item.Capacity.ToString());
            }
        }
        private void CreateButtonTable(string id, string table_name, string active, string capacity)
        {
            string stt = active == "1" ? "Có Người" : "Trống";
            Button button = new Button();
            button.Size = new Size(100, 50);
            if (stt == "Trống")
                button.BackColor = Color.MediumSeaGreen;
            else
                button.BackColor = Color.DarkOrange;
            button.Text = table_name + " \n [" + capacity + "] \n " + stt;
            button.Tag = id;
            button.Click += Button_Click;
            fpn_tables.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "Thêm món ăn cho bàn: " + (sender as Button).Text;
            if (_current_table_id == -1) _prv_table_id = -1;//int.Parse((sender as Button).Tag.ToString());
            else _prv_table_id = _current_table_id;
            _current_table_id = int.Parse((sender as Button).Tag.ToString());
            LoadFoodHavedAdd();
            BillBL billBL = new BillBL();
            int rs = billBL.GetBillHaveNotCheckOutByTableID(_current_table_id);
            if (rs > 0)
            {
                _curr_bill_id = rs;
            }
            this.Text = _prv_table_id.ToString() + ", " + _current_table_id.ToString() + ", " + _current_table_id + ", " + _curr_bill_id;

            CaculateTotalPayment();
        }

        private void LoadFoodHavedAdd()
        {
            FoodBL foodBL = new FoodBL();
            LoadDataForLvFood(foodBL.GetFoodHaveAddByTableID(_current_table_id));
            BillBL billBL = new BillBL();
            _curr_bill_id = billBL.GetBillHaveNotCheckOutByTableID(_current_table_id);
        }
        private void LoadDataForLvFood(SqlDataReader reader)
        {
            lv_bill_detail.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["Name"].ToString());
                item.SubItems.Add(reader["Quantily"].ToString());
                item.SubItems.Add(reader["Price"].ToString());
                item.SubItems.Add(reader["sum"].ToString());
                item.SubItems.Add(reader["ID"].ToString());
                lv_bill_detail.Items.Add(item);
            }
        }

        private void cbb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodBL foodBL = new FoodBL();
            int ID = ((Category)cbb_category.SelectedItem).ID;
            List<Food> foods = foodBL.FindByCategory(ID);
            cbb_food.DataSource = foods;
            cbb_food.DisplayMember = "Name";
            cbb_food.ValueMember = "ID";
        }

        private void btn_add_food_to_table_Click(object sender, EventArgs e)
        {
            BillBL billBL = new BillBL();
            int num = billBL.Insert(_current_table_id, _current_account_name);
            if (num > 0)
            {
                _curr_bill_id = num;
                _prv_table_id = _current_table_id;
                LoadDinningTable();
            }

            BillDetailBL billDetailBL = new BillDetailBL();
            int foodID = (int)cbb_food.SelectedValue;
            int num2 = billDetailBL.Insert(_curr_bill_id, foodID, int.Parse(dud_quantity.Text));
            if (num2 > 0)
            {
                FoodBL foodBL = new FoodBL();
                LoadDataForLvFood(foodBL.GetFoodHaveAddByTableID(_current_table_id));
            }
            CaculateTotalPayment();
        }


        private void CaculateTotalPayment()
        {
            int sum = 0;
            for (int i = 0; i < lv_bill_detail.Items.Count; i++)
            {
                sum += int.Parse(lv_bill_detail.Items[i].SubItems[3].Text);
            }
            txt_total.Text = sum.ToString();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            BillBL billBL = new BillBL();
            billBL.Pay(_current_table_id, _curr_bill_id, int.Parse(txt_total.Text), float.Parse(dud_discount.Text));
            lv_bill_detail.Items.Clear();
            LoadDinningTable();
            btn_pay.Enabled = false;
            _curr_bill_id = -1;
            dud_discount.Enabled = true;
            MessageBox.Show("Thanh Toán Bàn có ID: " + _current_table_id + ", tổng số tiền sau giảm giá: " + txt_total.Text);
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            double prv_sum = Double.Parse(txt_total.Text);
            double discount = double.Parse(dud_discount.Text);
            double final_sum = prv_sum - prv_sum * discount;
            txt_total.Text = final_sum.ToString();
            btn_pay.Enabled = true;
            dud_discount.Enabled = false;
        }

        private void tsm_delete_food_from_table_Click(object sender, EventArgs e)
        {
            BillDetailBL billDetailBL = new BillDetailBL();
           
            if (lv_bill_detail.CheckedItems.Count > 0)
            {
                for (int i = 0; i < lv_bill_detail.CheckedItems.Count; i++)
                {
                    billDetailBL.Delete(int.Parse(lv_bill_detail.CheckedItems[i].SubItems[4].Text));
                    lv_bill_detail.Items.Remove(lv_bill_detail.CheckedItems[i]);
                }
            }
            if (lv_bill_detail.Items.Count == 0)
            {
                BillBL billBL = new BillBL();
                billBL.Delete(_curr_bill_id);
                DiningTableBL diningTableBL = new DiningTableBL();
                diningTableBL.ResetStatus(_current_table_id);
                LoadDinningTable();
            }
        }

        private void tsm_Admin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.FormClosed += AdminForm_FormClosed;
            adminForm.Show();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDinningTable();
            InitView();
        }

        private void btn_move_table_Click(object sender, EventArgs e)
        {
            DiningTableBL diningTableBL = new DiningTableBL();
            int num = diningTableBL.MoveTable((int)cbb_dinning_table.SelectedValue, _current_table_id);
            if (num > 0)
            {
                MessageBox.Show("Chuyển bàn có ID = " + cbb_dinning_table.SelectedValue + " sang bàn có ID = " + _current_table_id);
                LoadDinningTable();
                LoadFoodHavedAdd();
            }
            else
            {
                MessageBox.Show("Lỗi Chuyển bàn!");
            }
        }

        private void btn_pool_table_Click(object sender, EventArgs e)
        {
            DiningTableBL diningTableBL = new DiningTableBL();
            int num = diningTableBL.PoolTable((int)cbb_dinning_table.SelectedValue, _current_table_id);
            if (num > 0)
            {
                MessageBox.Show("Gộp bàn có ID = " + cbb_dinning_table.SelectedValue + " vào bàn có ID = " + _current_table_id);
                LoadDinningTable();
                LoadFoodHavedAdd();
            }
            else
            {
                MessageBox.Show("Lỗi Gộp bàn!");
            }
        }
    }
}
