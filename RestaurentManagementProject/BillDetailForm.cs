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
    public partial class BillDetailForm : Form
    {
        public BillDetailForm()
        {
            InitializeComponent();
        }

        public void LoadFoods(int billID)
        {
            BillDetailBL billDetailBL = new BillDetailBL();
            DataTable dt = billDetailBL.GetFood(billID);
            dgv_foods_from_bill.DataSource = dt;

            dgv_foods_from_bill.Columns[0].HeaderText = "Mã số";
            dgv_foods_from_bill.Columns[1].HeaderText = "Tên món ăn";
            dgv_foods_from_bill.Columns[2].HeaderText = "Đơn vị";
            dgv_foods_from_bill.Columns[3].HeaderText = "Mô tả";
            dgv_foods_from_bill.Columns[4].HeaderText = "Đơn giá";
            dgv_foods_from_bill.Columns[5].HeaderText = "Số lượng";

            this.Text = "Danh Sách món ăn của bill số: " + billID;
            this.dgv_foods_from_bill.RowHeadersVisible = false;
            this.dgv_foods_from_bill.AllowUserToAddRows = false;
        }
    }
}
