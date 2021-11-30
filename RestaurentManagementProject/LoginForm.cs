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

namespace RestaurentManagementProject
{
    public partial class LoginForm : Form
    {
        public Boolean _Admin { get; private set; } = false;
        public string _Current_AccountName { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txt_account_name.Text = "lgCongcn";
            txt_password.Text = "legiacong";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (CheckAccount())
            {
                //Form1 form1 = new Form1();
                //form1.Show();
                this.Close();
            }
            else
            {
                lbl_error.Text = "Tên tài khoản hoặc mật khẩu không chính xác";
            }
        }
        private Boolean CheckAccount()
        {
            AccountBL accountBL = new AccountBL();
            DataTable dt = accountBL.GetAll();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (txt_account_name.Text == dt.Rows[i].ItemArray[0].ToString() && txt_password.Text == dt.Rows[i].ItemArray[1].ToString()
                    && dt.Rows[i].ItemArray[2].ToString() == "Adminstrator")
                {
                    _Current_AccountName = dt.Rows[i].ItemArray[0].ToString();
                    _Admin = true;
                    return true;
                }
                else if (txt_account_name.Text == dt.Rows[i].ItemArray[0].ToString() && txt_password.Text == dt.Rows[i].ItemArray[1].ToString()
                    && dt.Rows[i].ItemArray[2].ToString() != "Adminstrator")
                {
                    _Current_AccountName = dt.Rows[i].ItemArray[0].ToString();
                    _Admin = false;
                    return true;
                }
            }
            return false;
        }
    }
}
