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
    public partial class CategoryForm : Form
    {
        private List<Model.CategoryType> types = new List<Model.CategoryType>();
        public CategoryForm()
        {
            types.Add(new Model.CategoryType("Đồ ăn", 1));
            types.Add(new Model.CategoryType("Đồ uống", 0));
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            cbb_type.DataSource = types;
            cbb_type.DisplayMember = "Name";
            cbb_type.ValueMember = "Value";
            cbb_type.SelectedIndex = 0;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CategoryBL categoryBL = new CategoryBL();
            Category category = new Category
            {
                ID = 0,
                Name = txt_name_category.Text,
                Type = (int)cbb_type.SelectedValue
            };
            int num = categoryBL.Insert(category);
            if (num >= 0)
            {
                MessageBox.Show("Successfully adding new category" , "Message");
                this.ResetControl();
            }
            else
            {
                MessageBox.Show("Adding category failed");
            }
        }

        private void ResetControl()
        {
            txt_category_id.ResetText();
            txt_name_category.ResetText();
            cbb_type.ResetText();
        }
    }
}
