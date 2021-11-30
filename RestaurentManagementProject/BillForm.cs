using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace RestaurentManagementProject
{
    public partial class BillForm : Form
    {
        private int _tableID;
        public BillForm(string tableID)
        {
            _tableID = int.Parse(tableID);
            InitializeComponent();
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            BillBL billBL = new BillBL();
            DataTable dt = billBL.GetByDateAndTableID(_tableID, dtp_date.Value.Date.ToString()); ;
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

            dgv_bills.RowHeadersVisible = false;
            dgv_bills.AllowUserToAddRows = false;

            if (dt.Rows.Count > 0)
            {
                lbl_sum.Text = billBL.GetSalary(_tableID, dtp_date.Value.Date.ToString()).ToString();
            }

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

    }
}
