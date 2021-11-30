
namespace RestaurentManagementProject
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_search_by_name = new System.Windows.Forms.TextBox();
            this.lbl_category_name = new System.Windows.Forms.Label();
            this.lbl_quantily = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_foods = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_caculater_quantily = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_add_food = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_update_food = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_Tabels = new System.Windows.Forms.DataGridView();
            this.btn_view_bill_table = new System.Windows.Forms.Button();
            this.btn_remove_table = new System.Windows.Forms.Button();
            this.btn_Clear_table = new System.Windows.Forms.Button();
            this.btn_save_table = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_Capacity = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv_bills = new System.Windows.Forms.DataGridView();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_tell = new System.Windows.Forms.TextBox();
            this.cbb_stt = new System.Windows.Forms.ComboBox();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_account_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.cbb_Group = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Change_pasword = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_Accounts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_viewDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_view_catalogs = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foods)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tabels)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 678);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_search_by_name);
            this.tabPage1.Controls.Add(this.lbl_category_name);
            this.tabPage1.Controls.Add(this.lbl_quantily);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbb_category);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_foods);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý thức ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_search_by_name
            // 
            this.txt_search_by_name.Location = new System.Drawing.Point(611, 6);
            this.txt_search_by_name.Name = "txt_search_by_name";
            this.txt_search_by_name.Size = new System.Drawing.Size(244, 24);
            this.txt_search_by_name.TabIndex = 13;
            this.txt_search_by_name.TextChanged += new System.EventHandler(this.txt_search_by_name_TextChanged);
            // 
            // lbl_category_name
            // 
            this.lbl_category_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_category_name.AutoSize = true;
            this.lbl_category_name.Location = new System.Drawing.Point(300, 624);
            this.lbl_category_name.Name = "lbl_category_name";
            this.lbl_category_name.Size = new System.Drawing.Size(20, 18);
            this.lbl_category_name.TabIndex = 9;
            this.lbl_category_name.Text = "...";
            // 
            // lbl_quantily
            // 
            this.lbl_quantily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_quantily.AutoSize = true;
            this.lbl_quantily.Location = new System.Drawing.Point(88, 624);
            this.lbl_quantily.Name = "lbl_quantily";
            this.lbl_quantily.Size = new System.Drawing.Size(20, 18);
            this.lbl_quantily.TabIndex = 10;
            this.lbl_quantily.Text = "...";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "món ăn thuộc nhóm";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Có tất cả";
            // 
            // cbb_category
            // 
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Location = new System.Drawing.Point(164, 6);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(244, 26);
            this.cbb_category.TabIndex = 8;
            this.cbb_category.SelectedIndexChanged += new System.EventHandler(this.cbb_category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm theo tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn nhóm món ăn";
            // 
            // dgv_foods
            // 
            this.dgv_foods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_foods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_foods.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_foods.Location = new System.Drawing.Point(9, 52);
            this.dgv_foods.MultiSelect = false;
            this.dgv_foods.Name = "dgv_foods";
            this.dgv_foods.ReadOnly = true;
            this.dgv_foods.RowHeadersWidth = 51;
            this.dgv_foods.RowTemplate.Height = 24;
            this.dgv_foods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_foods.Size = new System.Drawing.Size(866, 569);
            this.dgv_foods.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_caculater_quantily,
            this.toolStripSeparator1,
            this.tsm_add_food,
            this.tsm_update_food});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 82);
            // 
            // tsm_caculater_quantily
            // 
            this.tsm_caculater_quantily.Name = "tsm_caculater_quantily";
            this.tsm_caculater_quantily.Size = new System.Drawing.Size(218, 24);
            this.tsm_caculater_quantily.Text = "Tính số lượng đã bán";
            this.tsm_caculater_quantily.Click += new System.EventHandler(this.tsm_caculater_quantily_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // tsm_add_food
            // 
            this.tsm_add_food.Name = "tsm_add_food";
            this.tsm_add_food.Size = new System.Drawing.Size(218, 24);
            this.tsm_add_food.Text = "Thêm món ăn";
            this.tsm_add_food.Click += new System.EventHandler(this.tsm_add_food_Click);
            // 
            // tsm_update_food
            // 
            this.tsm_update_food.Name = "tsm_update_food";
            this.tsm_update_food.Size = new System.Drawing.Size(218, 24);
            this.tsm_update_food.Text = "Cập nhật món ăn";
            this.tsm_update_food.Click += new System.EventHandler(this.tsm_update_food_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_Tabels);
            this.tabPage2.Controls.Add(this.btn_view_bill_table);
            this.tabPage2.Controls.Add(this.btn_remove_table);
            this.tabPage2.Controls.Add(this.btn_Clear_table);
            this.tabPage2.Controls.Add(this.btn_save_table);
            this.tabPage2.Controls.Add(this.txt_name);
            this.tabPage2.Controls.Add(this.txt_Capacity);
            this.tabPage2.Controls.Add(this.txt_id);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý bàn ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_Tabels
            // 
            this.dgv_Tabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tabels.Location = new System.Drawing.Point(9, 7);
            this.dgv_Tabels.Name = "dgv_Tabels";
            this.dgv_Tabels.ReadOnly = true;
            this.dgv_Tabels.RowHeadersWidth = 51;
            this.dgv_Tabels.RowTemplate.Height = 24;
            this.dgv_Tabels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Tabels.Size = new System.Drawing.Size(529, 634);
            this.dgv_Tabels.TabIndex = 5;
            this.dgv_Tabels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tabels_CellClick);
            this.dgv_Tabels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tabels_CellContentClick);
            // 
            // btn_view_bill_table
            // 
            this.btn_view_bill_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_bill_table.Location = new System.Drawing.Point(582, 174);
            this.btn_view_bill_table.Name = "btn_view_bill_table";
            this.btn_view_bill_table.Size = new System.Drawing.Size(294, 30);
            this.btn_view_bill_table.TabIndex = 4;
            this.btn_view_bill_table.Text = "Xem hóa đơn";
            this.btn_view_bill_table.UseVisualStyleBackColor = true;
            this.btn_view_bill_table.Click += new System.EventHandler(this.btn_view_bill_table_Click);
            // 
            // btn_remove_table
            // 
            this.btn_remove_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_table.Location = new System.Drawing.Point(744, 522);
            this.btn_remove_table.Name = "btn_remove_table";
            this.btn_remove_table.Size = new System.Drawing.Size(138, 27);
            this.btn_remove_table.TabIndex = 4;
            this.btn_remove_table.Text = "Xóa";
            this.btn_remove_table.UseVisualStyleBackColor = true;
            this.btn_remove_table.Visible = false;
            this.btn_remove_table.Click += new System.EventHandler(this.btn_remove_table_Click);
            // 
            // btn_Clear_table
            // 
            this.btn_Clear_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear_table.Location = new System.Drawing.Point(736, 138);
            this.btn_Clear_table.Name = "btn_Clear_table";
            this.btn_Clear_table.Size = new System.Drawing.Size(140, 30);
            this.btn_Clear_table.TabIndex = 4;
            this.btn_Clear_table.Text = "Xóa trắng";
            this.btn_Clear_table.UseVisualStyleBackColor = true;
            this.btn_Clear_table.Click += new System.EventHandler(this.btn_Clear_table_Click);
            // 
            // btn_save_table
            // 
            this.btn_save_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_table.Location = new System.Drawing.Point(582, 138);
            this.btn_save_table.Name = "btn_save_table";
            this.btn_save_table.Size = new System.Drawing.Size(140, 30);
            this.btn_save_table.TabIndex = 4;
            this.btn_save_table.Text = "Lưu";
            this.btn_save_table.UseVisualStyleBackColor = true;
            this.btn_save_table.Click += new System.EventHandler(this.btn_save_table_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(696, 45);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 24);
            this.txt_name.TabIndex = 1;
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Capacity.Location = new System.Drawing.Point(696, 75);
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.Size = new System.Drawing.Size(180, 24);
            this.txt_Capacity.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(696, 15);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(180, 24);
            this.txt_id.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(579, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 18);
            this.label18.TabIndex = 0;
            this.label18.Text = "Số chổ ngồi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(579, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tên bàn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(579, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mã số bàn";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_sum);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.dgv_bills);
            this.tabPage3.Controls.Add(this.dtp_date);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(888, 647);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý hóa đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sum.Location = new System.Drawing.Point(158, 624);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(20, 18);
            this.lbl_sum.TabIndex = 6;
            this.lbl_sum.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 624);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Số tiền bán được";
            // 
            // dgv_bills
            // 
            this.dgv_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bills.Location = new System.Drawing.Point(8, 58);
            this.dgv_bills.Name = "dgv_bills";
            this.dgv_bills.ReadOnly = true;
            this.dgv_bills.RowHeadersWidth = 51;
            this.dgv_bills.RowTemplate.Height = 24;
            this.dgv_bills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bills.Size = new System.Drawing.Size(872, 553);
            this.dgv_bills.TabIndex = 4;
            this.dgv_bills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellDoubleClick);
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(118, 13);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(134, 24);
            this.dtp_date.TabIndex = 3;
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Chọn ngày";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.btn_Change_pasword);
            this.tabPage4.Controls.Add(this.btn_Save);
            this.tabPage4.Controls.Add(this.btn_Clear);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.dgv_Accounts);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(888, 647);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quản lý tài khoản";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_fullname);
            this.groupBox1.Controls.Add(this.txt_tell);
            this.groupBox1.Controls.Add(this.cbb_stt);
            this.groupBox1.Controls.Add(this.cbb_role);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_account_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Location = new System.Drawing.Point(201, 43);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(164, 24);
            this.txt_fullname.TabIndex = 1;
            // 
            // txt_tell
            // 
            this.txt_tell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tell.Location = new System.Drawing.Point(201, 99);
            this.txt_tell.Name = "txt_tell";
            this.txt_tell.Size = new System.Drawing.Size(164, 24);
            this.txt_tell.TabIndex = 1;
            // 
            // cbb_stt
            // 
            this.cbb_stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_stt.FormattingEnabled = true;
            this.cbb_stt.Items.AddRange(new object[] {
            "Actived",
            "Nonactived"});
            this.cbb_stt.Location = new System.Drawing.Point(548, 54);
            this.cbb_stt.Name = "cbb_stt";
            this.cbb_stt.Size = new System.Drawing.Size(164, 26);
            this.cbb_stt.TabIndex = 2;
            // 
            // cbb_role
            // 
            this.cbb_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Location = new System.Drawing.Point(548, 15);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(164, 26);
            this.cbb_role.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(201, 71);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 24);
            this.txt_email.TabIndex = 1;
            // 
            // txt_account_name
            // 
            this.txt_account_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_account_name.Location = new System.Drawing.Point(201, 15);
            this.txt_account_name.Name = "txt_account_name";
            this.txt_account_name.Size = new System.Drawing.Size(164, 24);
            this.txt_account_name.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện Thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Trạng Thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quyền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(91, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Họ Và Tên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên Tài Khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_Status);
            this.groupBox2.Controls.Add(this.cbb_Group);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 42);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            // 
            // cbb_Status
            // 
            this.cbb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Items.AddRange(new object[] {
            "Actived",
            "Nonactived"});
            this.cbb_Status.Location = new System.Drawing.Point(512, 12);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(200, 24);
            this.cbb_Status.TabIndex = 8;
            // 
            // cbb_Group
            // 
            this.cbb_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Group.FormattingEnabled = true;
            this.cbb_Group.Location = new System.Drawing.Point(165, 12);
            this.cbb_Group.Name = "cbb_Group";
            this.cbb_Group.Size = new System.Drawing.Size(200, 24);
            this.cbb_Group.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nhóm";
            // 
            // btn_Change_pasword
            // 
            this.btn_Change_pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change_pasword.Location = new System.Drawing.Point(727, 121);
            this.btn_Change_pasword.Name = "btn_Change_pasword";
            this.btn_Change_pasword.Size = new System.Drawing.Size(153, 30);
            this.btn_Change_pasword.TabIndex = 4;
            this.btn_Change_pasword.Text = "Đổi mật khẩu";
            this.btn_Change_pasword.UseVisualStyleBackColor = true;
            this.btn_Change_pasword.Click += new System.EventHandler(this.btn_Change_Pasword_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(727, 85);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(153, 30);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(727, 49);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(153, 30);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Xóa Trắng";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(727, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lấy Danh Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_Accounts
            // 
            this.dgv_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accounts.ContextMenuStrip = this.contextMenuStrip2;
            this.dgv_Accounts.Location = new System.Drawing.Point(3, 185);
            this.dgv_Accounts.Name = "dgv_Accounts";
            this.dgv_Accounts.ReadOnly = true;
            this.dgv_Accounts.RowHeadersWidth = 51;
            this.dgv_Accounts.RowTemplate.Height = 24;
            this.dgv_Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Accounts.Size = new System.Drawing.Size(877, 454);
            this.dgv_Accounts.TabIndex = 0;
            this.dgv_Accounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Accounts_CellClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Remove,
            this.tsm_viewDetail,
            this.tsm_view_catalogs});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(242, 76);
            // 
            // tsm_Remove
            // 
            this.tsm_Remove.Name = "tsm_Remove";
            this.tsm_Remove.Size = new System.Drawing.Size(241, 24);
            this.tsm_Remove.Text = "Xóa Tài Khoản";
            this.tsm_Remove.Click += new System.EventHandler(this.tsm_Remove_Click);
            // 
            // tsm_viewDetail
            // 
            this.tsm_viewDetail.Name = "tsm_viewDetail";
            this.tsm_viewDetail.Size = new System.Drawing.Size(241, 24);
            this.tsm_viewDetail.Text = "Xem Danh Sách Vai Trò";
            this.tsm_viewDetail.Click += new System.EventHandler(this.tsm_viewDetail_Click);
            // 
            // tsm_view_catalogs
            // 
            this.tsm_view_catalogs.Name = "tsm_view_catalogs";
            this.tsm_view_catalogs.Size = new System.Drawing.Size(241, 24);
            this.tsm_view_catalogs.Text = "Xem Nhật Ký Hoạt Động";
            this.tsm_view_catalogs.Click += new System.EventHandler(this.tsm_view_catalogs_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 678);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "Giao diện quản lý";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foods)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tabels)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_search_by_name;
        private System.Windows.Forms.Label lbl_category_name;
        private System.Windows.Forms.Label lbl_quantily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_foods;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_caculater_quantily;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsm_add_food;
        private System.Windows.Forms.ToolStripMenuItem tsm_update_food;
        private System.Windows.Forms.DataGridView dgv_Accounts;
        private System.Windows.Forms.Button btn_Change_pasword;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_Status;
        private System.Windows.Forms.ComboBox cbb_Group;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_tell;
        private System.Windows.Forms.ComboBox cbb_stt;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_account_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsm_Remove;
        private System.Windows.Forms.ToolStripMenuItem tsm_viewDetail;
        private System.Windows.Forms.ToolStripMenuItem tsm_view_catalogs;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_bills;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_Capacity;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_remove_table;
        private System.Windows.Forms.Button btn_Clear_table;
        private System.Windows.Forms.Button btn_save_table;
        private System.Windows.Forms.Button btn_view_bill_table;
        private System.Windows.Forms.DataGridView dgv_Tabels;
    }
}