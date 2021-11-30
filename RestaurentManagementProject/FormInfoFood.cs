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
    public partial class FormInfoFood : Form
    {
        public FormInfoFood()
        {
            InitializeComponent();
        }
        private void InnitValues()
        {
            CategoryBL categoryBL = new CategoryBL();
            DataSet ds = categoryBL.GetAllDataSet();

            cbb_category_naem.DataSource = ds.Tables["Category"];
            cbb_category_naem.DisplayMember = "Name";
            cbb_category_naem.ValueMember = "ID";
        }
        private void ResetControl()
        {
            txt_food_id.Text = "";
            txt_name_food.Text = "";
            txt_notes_food.Text = "";
            txt_unit_food.Text = "";
            dud_prices.ResetText();
            cbb_category_naem.ResetText();
        }
        private int InsertFood()
        {
            Food food = new Food();
            food.ID = 0;
            if (txt_name_food.Text == "" || txt_unit_food.Text == "" || dud_prices.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                //Nhận giá trị Name, Unit, và Notes từ người dùng nhập vào
                food.Name = txt_name_food.Text;
                food.Unit = txt_unit_food.Text;
                food.Notes = txt_notes_food.Text;
                // Giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
                int price = 0;
                try
                {
                    // Cố gắng lấy giá trị
                    price = int.Parse(dud_prices.Text);
                }
                catch
                {
                    // Nếu sai, gán giá = 0
                    price = 0;
                }
                food.Price = price;
                // Giá trị FoodCategoryID được lấy từ ComboBox
                food.FoodCategoryID = int.Parse(cbb_category_naem.SelectedValue.ToString());
                // Khao báo đối tượng FoodBL từ tầng Business
                FoodBL foodBL = new FoodBL();
                // Chèn dữ liệu vào bảng
                return foodBL.Insert(food);
            }
            return -1;
        }
        
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txt_food_id.Text = rowView["ID"].ToString();
                txt_name_food.Text = rowView["Name"].ToString();
                txt_unit_food.Text = rowView["Unit"].ToString();
                txt_notes_food.Text = rowView["Notes"].ToString();
                dud_prices.Text = rowView["Price"].ToString();

                cbb_category_naem.SelectedIndex = -1;
                //this.Text = rowView["FoodCategotyID"].ToString();
                for (int i = 0; i < cbb_category_naem.Items.Count; i++)
                {
                    DataRowView cat = cbb_category_naem.Items[i] as DataRowView;

                    if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbb_category_naem.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch (Exception ex) { }

        }

   

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_new_category_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.FormClosed += new FormClosedEventHandler(categoryForm_FormClose);
            categoryForm.Show(this);
        }
        private void categoryForm_FormClose(object sender, FormClosedEventArgs e)
        {
            InnitValues();
        }

        private void FormInfoFood_Load(object sender, EventArgs e)
        {
            InnitValues();
        }
        private void AddFood()
        {
            int num = InsertFood();
            if (num > 0)
            {
                //string foodID = sqlCommand.Parameters["@ID"].Value.ToString();
                MessageBox.Show("Successfully adding new food", "Message");
                this.ResetControl();
            }
            else
            {
                MessageBox.Show("Adding food failed");
            }
        }
        private void UpdateFood()
        {
            if (cbb_category_naem.Text != "")
            {
                Food food = new Food();
                food.ID = int.Parse(txt_food_id.Text);
                food.Name = txt_name_food.Text;
                food.Unit = txt_unit_food.Text;
                food.Notes = txt_notes_food.Text;
                // Giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai
                int price = 0;
                try
                {
                    // Cố gắng lấy giá trị
                    price = int.Parse(dud_prices.Text);
                }
                catch
                {
                    // Nếu sai, gán giá = 0
                    price = 0;
                }
                food.Price = price;
                // Giá trị FoodCategoryID được lấy từ ComboBox
                food.FoodCategoryID = int.Parse(cbb_category_naem.SelectedValue.ToString());
                // Khao báo đối tượng FoodBL từ tầng Business
                FoodBL foodBL = new FoodBL();
                // Chèn dữ liệu vào bảng
                int num = foodBL.Update(food);
                
                if (num > 0)
                {
                    MessageBox.Show("Successfully updating food");
                    this.ResetControl();
                }
                else
                {
                    MessageBox.Show("Update food failed");
                }
               
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_food_id.Text != "")
            {
                UpdateFood();
            }
            else
            {
                AddFood();
            }
        }

    }
}
