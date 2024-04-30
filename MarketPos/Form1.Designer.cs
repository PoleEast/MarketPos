namespace MarketPos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lbPage = new Label();
            cbPage = new ComboBox();
            btnBackPage = new Button();
            btnNextPage = new Button();
            productCard8 = new ProductCard();
            productCard7 = new ProductCard();
            productCard6 = new ProductCard();
            productCard5 = new ProductCard();
            productCard4 = new ProductCard();
            productCard3 = new ProductCard();
            productCard2 = new ProductCard();
            productCard1 = new ProductCard();
            tabPage2 = new TabPage();
            label1 = new Label();
            tabControl2 = new TabControl();
            tbpControl = new TabPage();
            cbAddCategoryType = new Button();
            label2 = new Label();
            cbAddP_origin = new ComboBox();
            btnAddOriginType = new Button();
            btntest = new Button();
            cbAddP_stock = new ComboBox();
            btnAddProduct = new Button();
            rtbAddP_description = new RichTextBox();
            txbAddP_weight = new TextBox();
            txbAddP_price = new TextBox();
            txbAddP_name = new TextBox();
            cbAddP_category = new ComboBox();
            lbAddP_description = new Label();
            lbAddP_stock = new Label();
            lbAddP_origin = new Label();
            lbAddP_weight = new Label();
            lbAddP_price = new Label();
            lbAddP_category = new Label();
            lbAddP_name = new Label();
            tbpMemSerch = new TabPage();
            label3 = new Label();
            txbS_Name = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txbS_Price = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            comboBox2 = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tbpControl.SuspendLayout();
            tbpMemSerch.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(28, 49);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1084, 782);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(lbPage);
            tabPage1.Controls.Add(cbPage);
            tabPage1.Controls.Add(btnBackPage);
            tabPage1.Controls.Add(btnNextPage);
            tabPage1.Controls.Add(productCard8);
            tabPage1.Controls.Add(productCard7);
            tabPage1.Controls.Add(productCard6);
            tabPage1.Controls.Add(productCard5);
            tabPage1.Controls.Add(productCard4);
            tabPage1.Controls.Add(productCard3);
            tabPage1.Controls.Add(productCard2);
            tabPage1.Controls.Add(productCard1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1076, 754);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbPage
            // 
            lbPage.AutoSize = true;
            lbPage.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbPage.Location = new Point(895, 705);
            lbPage.Name = "lbPage";
            lbPage.Size = new Size(42, 17);
            lbPage.TabIndex = 20;
            lbPage.Text = "/10頁";
            // 
            // cbPage
            // 
            cbPage.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbPage.FormattingEnabled = true;
            cbPage.Location = new Point(839, 690);
            cbPage.Name = "cbPage";
            cbPage.Size = new Size(50, 32);
            cbPage.TabIndex = 19;
            cbPage.SelectedIndexChanged += cbPage_SelectedIndexChanged;
            // 
            // btnBackPage
            // 
            btnBackPage.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnBackPage.Location = new Point(727, 685);
            btnBackPage.Name = "btnBackPage";
            btnBackPage.Size = new Size(96, 43);
            btnBackPage.TabIndex = 18;
            btnBackPage.Text = "上一頁";
            btnBackPage.UseVisualStyleBackColor = true;
            btnBackPage.Click += btnBackPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnNextPage.Location = new Point(951, 685);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(96, 43);
            btnNextPage.TabIndex = 17;
            btnNextPage.Text = "下一頁";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // productCard8
            // 
            productCard8.BorderStyle = BorderStyle.FixedSingle;
            productCard8.Location = new Point(817, 354);
            productCard8.Name = "productCard8";
            productCard8.Size = new Size(230, 304);
            productCard8.TabIndex = 15;
            productCard8.Visible = false;
            // 
            // productCard7
            // 
            productCard7.BorderStyle = BorderStyle.FixedSingle;
            productCard7.Location = new Point(557, 354);
            productCard7.Name = "productCard7";
            productCard7.Size = new Size(230, 304);
            productCard7.TabIndex = 14;
            productCard7.Visible = false;
            // 
            // productCard6
            // 
            productCard6.BorderStyle = BorderStyle.FixedSingle;
            productCard6.Location = new Point(296, 354);
            productCard6.Name = "productCard6";
            productCard6.Size = new Size(230, 304);
            productCard6.TabIndex = 13;
            productCard6.Visible = false;
            // 
            // productCard5
            // 
            productCard5.BorderStyle = BorderStyle.FixedSingle;
            productCard5.Location = new Point(25, 354);
            productCard5.Name = "productCard5";
            productCard5.Size = new Size(230, 304);
            productCard5.TabIndex = 12;
            productCard5.Visible = false;
            // 
            // productCard4
            // 
            productCard4.BorderStyle = BorderStyle.FixedSingle;
            productCard4.Location = new Point(817, 19);
            productCard4.Name = "productCard4";
            productCard4.Size = new Size(230, 304);
            productCard4.TabIndex = 11;
            productCard4.Visible = false;
            // 
            // productCard3
            // 
            productCard3.BorderStyle = BorderStyle.FixedSingle;
            productCard3.Location = new Point(557, 19);
            productCard3.Name = "productCard3";
            productCard3.Size = new Size(230, 304);
            productCard3.TabIndex = 10;
            productCard3.Visible = false;
            // 
            // productCard2
            // 
            productCard2.BorderStyle = BorderStyle.FixedSingle;
            productCard2.Location = new Point(296, 19);
            productCard2.Name = "productCard2";
            productCard2.Size = new Size(230, 304);
            productCard2.TabIndex = 9;
            productCard2.Visible = false;
            // 
            // productCard1
            // 
            productCard1.BorderStyle = BorderStyle.FixedSingle;
            productCard1.Location = new Point(25, 19);
            productCard1.Name = "productCard1";
            productCard1.Size = new Size(230, 304);
            productCard1.TabIndex = 8;
            productCard1.Visible = false;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1076, 754);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(498, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 41);
            label1.TabIndex = 9;
            label1.Text = "大港開吃";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tbpMemSerch);
            tabControl2.Controls.Add(tbpControl);
            tabControl2.Location = new Point(1114, 49);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(470, 782);
            tabControl2.TabIndex = 10;
            // 
            // tbpControl
            // 
            tbpControl.BorderStyle = BorderStyle.FixedSingle;
            tbpControl.Controls.Add(cbAddCategoryType);
            tbpControl.Controls.Add(label2);
            tbpControl.Controls.Add(cbAddP_origin);
            tbpControl.Controls.Add(btnAddOriginType);
            tbpControl.Controls.Add(btntest);
            tbpControl.Controls.Add(cbAddP_stock);
            tbpControl.Controls.Add(btnAddProduct);
            tbpControl.Controls.Add(rtbAddP_description);
            tbpControl.Controls.Add(txbAddP_weight);
            tbpControl.Controls.Add(txbAddP_price);
            tbpControl.Controls.Add(txbAddP_name);
            tbpControl.Controls.Add(cbAddP_category);
            tbpControl.Controls.Add(lbAddP_description);
            tbpControl.Controls.Add(lbAddP_stock);
            tbpControl.Controls.Add(lbAddP_origin);
            tbpControl.Controls.Add(lbAddP_weight);
            tbpControl.Controls.Add(lbAddP_price);
            tbpControl.Controls.Add(lbAddP_category);
            tbpControl.Controls.Add(lbAddP_name);
            tbpControl.Location = new Point(4, 24);
            tbpControl.Name = "tbpControl";
            tbpControl.Padding = new Padding(3);
            tbpControl.Size = new Size(462, 754);
            tbpControl.TabIndex = 0;
            tbpControl.Text = "管理者";
            tbpControl.UseVisualStyleBackColor = true;
            // 
            // cbAddCategoryType
            // 
            cbAddCategoryType.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbAddCategoryType.Location = new Point(278, 118);
            cbAddCategoryType.Name = "cbAddCategoryType";
            cbAddCategoryType.Size = new Size(63, 25);
            cbAddCategoryType.TabIndex = 20;
            cbAddCategoryType.Text = "新增類別";
            cbAddCategoryType.UseVisualStyleBackColor = true;
            cbAddCategoryType.Click += cbAddCategoryType_Click;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(269, 245);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 19;
            label2.Text = "公克(g)";
            // 
            // cbAddP_origin
            // 
            cbAddP_origin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAddP_origin.FormattingEnabled = true;
            cbAddP_origin.Location = new Point(93, 300);
            cbAddP_origin.Name = "cbAddP_origin";
            cbAddP_origin.Size = new Size(170, 23);
            cbAddP_origin.TabIndex = 18;
            cbAddP_origin.HandleCreated += cbAddP_origin_HandleCreated;
            // 
            // btnAddOriginType
            // 
            btnAddOriginType.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnAddOriginType.Location = new Point(278, 299);
            btnAddOriginType.Name = "btnAddOriginType";
            btnAddOriginType.Size = new Size(63, 25);
            btnAddOriginType.TabIndex = 17;
            btnAddOriginType.Text = "新增產地";
            btnAddOriginType.UseVisualStyleBackColor = true;
            btnAddOriginType.Click += btnAddOriginType_Click;
            // 
            // btntest
            // 
            btntest.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btntest.Location = new Point(58, 566);
            btntest.Name = "btntest";
            btntest.Size = new Size(96, 43);
            btntest.TabIndex = 16;
            btntest.Text = "測試按鈕";
            btntest.UseVisualStyleBackColor = true;
            btntest.Click += btntest_Click;
            // 
            // cbAddP_stock
            // 
            cbAddP_stock.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAddP_stock.FormattingEnabled = true;
            cbAddP_stock.ImeMode = ImeMode.NoControl;
            cbAddP_stock.Location = new Point(93, 354);
            cbAddP_stock.Name = "cbAddP_stock";
            cbAddP_stock.Size = new Size(170, 23);
            cbAddP_stock.TabIndex = 15;
            cbAddP_stock.HandleCreated += cbAddP_stock_HandleCreated;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnAddProduct.Location = new Point(325, 566);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(96, 43);
            btnAddProduct.TabIndex = 14;
            btnAddProduct.Text = "新增商品";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // rtbAddP_description
            // 
            rtbAddP_description.Location = new Point(102, 416);
            rtbAddP_description.Name = "rtbAddP_description";
            rtbAddP_description.Size = new Size(319, 116);
            rtbAddP_description.TabIndex = 13;
            rtbAddP_description.Text = "";
            // 
            // txbAddP_weight
            // 
            txbAddP_weight.Location = new Point(93, 240);
            txbAddP_weight.MaxLength = 8;
            txbAddP_weight.Name = "txbAddP_weight";
            txbAddP_weight.Size = new Size(170, 23);
            txbAddP_weight.TabIndex = 10;
            // 
            // txbAddP_price
            // 
            txbAddP_price.Location = new Point(93, 180);
            txbAddP_price.MaxLength = 8;
            txbAddP_price.Name = "txbAddP_price";
            txbAddP_price.Size = new Size(170, 23);
            txbAddP_price.TabIndex = 9;
            txbAddP_price.KeyPress += txbAddP_price_KeyPress;
            // 
            // txbAddP_name
            // 
            txbAddP_name.Location = new Point(93, 59);
            txbAddP_name.MaxLength = 30;
            txbAddP_name.Name = "txbAddP_name";
            txbAddP_name.Size = new Size(170, 23);
            txbAddP_name.TabIndex = 8;
            // 
            // cbAddP_category
            // 
            cbAddP_category.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAddP_category.FormattingEnabled = true;
            cbAddP_category.Location = new Point(93, 118);
            cbAddP_category.Name = "cbAddP_category";
            cbAddP_category.Size = new Size(170, 23);
            cbAddP_category.TabIndex = 7;
            cbAddP_category.HandleCreated += cbAddP_category_HandleCreated;
            // 
            // lbAddP_description
            // 
            lbAddP_description.AutoEllipsis = true;
            lbAddP_description.AutoSize = true;
            lbAddP_description.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_description.Location = new Point(28, 412);
            lbAddP_description.Name = "lbAddP_description";
            lbAddP_description.Size = new Size(48, 24);
            lbAddP_description.TabIndex = 6;
            lbAddP_description.Text = "描述";
            // 
            // lbAddP_stock
            // 
            lbAddP_stock.AutoEllipsis = true;
            lbAddP_stock.AutoSize = true;
            lbAddP_stock.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_stock.Location = new Point(28, 354);
            lbAddP_stock.Name = "lbAddP_stock";
            lbAddP_stock.Size = new Size(48, 24);
            lbAddP_stock.TabIndex = 5;
            lbAddP_stock.Text = "庫存";
            // 
            // lbAddP_origin
            // 
            lbAddP_origin.AutoEllipsis = true;
            lbAddP_origin.AutoSize = true;
            lbAddP_origin.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_origin.Location = new Point(28, 299);
            lbAddP_origin.Name = "lbAddP_origin";
            lbAddP_origin.Size = new Size(48, 24);
            lbAddP_origin.TabIndex = 4;
            lbAddP_origin.Text = "產地";
            // 
            // lbAddP_weight
            // 
            lbAddP_weight.AutoEllipsis = true;
            lbAddP_weight.AutoSize = true;
            lbAddP_weight.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_weight.Location = new Point(28, 240);
            lbAddP_weight.Name = "lbAddP_weight";
            lbAddP_weight.Size = new Size(48, 24);
            lbAddP_weight.TabIndex = 3;
            lbAddP_weight.Text = "重量";
            // 
            // lbAddP_price
            // 
            lbAddP_price.AutoEllipsis = true;
            lbAddP_price.AutoSize = true;
            lbAddP_price.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_price.Location = new Point(28, 180);
            lbAddP_price.Name = "lbAddP_price";
            lbAddP_price.Size = new Size(48, 24);
            lbAddP_price.TabIndex = 2;
            lbAddP_price.Text = "價格";
            // 
            // lbAddP_category
            // 
            lbAddP_category.AutoEllipsis = true;
            lbAddP_category.AutoSize = true;
            lbAddP_category.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_category.Location = new Point(28, 118);
            lbAddP_category.Name = "lbAddP_category";
            lbAddP_category.Size = new Size(48, 24);
            lbAddP_category.TabIndex = 1;
            lbAddP_category.Text = "種類";
            // 
            // lbAddP_name
            // 
            lbAddP_name.AutoEllipsis = true;
            lbAddP_name.AutoSize = true;
            lbAddP_name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_name.Location = new Point(28, 59);
            lbAddP_name.Name = "lbAddP_name";
            lbAddP_name.Size = new Size(48, 24);
            lbAddP_name.TabIndex = 0;
            lbAddP_name.Text = "名稱";
            // 
            // tbpMemSerch
            // 
            tbpMemSerch.Controls.Add(comboBox2);
            tbpMemSerch.Controls.Add(label7);
            tbpMemSerch.Controls.Add(button3);
            tbpMemSerch.Controls.Add(button4);
            tbpMemSerch.Controls.Add(textBox3);
            tbpMemSerch.Controls.Add(label6);
            tbpMemSerch.Controls.Add(button2);
            tbpMemSerch.Controls.Add(button1);
            tbpMemSerch.Controls.Add(txbS_Price);
            tbpMemSerch.Controls.Add(label5);
            tbpMemSerch.Controls.Add(label4);
            tbpMemSerch.Controls.Add(comboBox1);
            tbpMemSerch.Controls.Add(txbS_Name);
            tbpMemSerch.Controls.Add(label3);
            tbpMemSerch.Location = new Point(4, 24);
            tbpMemSerch.Name = "tbpMemSerch";
            tbpMemSerch.Padding = new Padding(3);
            tbpMemSerch.Size = new Size(462, 754);
            tbpMemSerch.TabIndex = 1;
            tbpMemSerch.Text = "商品查詢";
            tbpMemSerch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(61, 108);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 1;
            label3.Text = "名稱";
            // 
            // txbS_Name
            // 
            txbS_Name.Location = new Point(115, 108);
            txbS_Name.MaxLength = 30;
            txbS_Name.Name = "txbS_Name";
            txbS_Name.Size = new Size(170, 23);
            txbS_Name.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(115, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(61, 158);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 11;
            label4.Text = "種類";
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(61, 210);
            label5.Name = "label5";
            label5.Size = new Size(48, 24);
            label5.TabIndex = 12;
            label5.Text = "價格";
            // 
            // txbS_Price
            // 
            txbS_Price.Location = new Point(115, 210);
            txbS_Price.MaxLength = 30;
            txbS_Price.Name = "txbS_Price";
            txbS_Price.Size = new Size(170, 23);
            txbS_Price.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(298, 210);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 21;
            button1.Text = "新增類別";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(367, 210);
            button2.Name = "button2";
            button2.Size = new Size(63, 23);
            button2.TabIndex = 22;
            button2.Text = "新增類別";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 262);
            textBox3.MaxLength = 30;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.Location = new Point(61, 262);
            label6.Name = "label6";
            label6.Size = new Size(48, 24);
            label6.TabIndex = 23;
            label6.Text = "重量";
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button3.Location = new Point(367, 262);
            button3.Name = "button3";
            button3.Size = new Size(63, 23);
            button3.TabIndex = 26;
            button3.Text = "新增類別";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button4.Location = new Point(298, 262);
            button4.Name = "button4";
            button4.Size = new Size(63, 23);
            button4.TabIndex = 25;
            button4.Text = "新增類別";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(61, 311);
            label7.Name = "label7";
            label7.Size = new Size(48, 24);
            label7.TabIndex = 27;
            label7.Text = "產地";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(115, 311);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 23);
            comboBox2.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(tabControl2);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl2.ResumeLayout(false);
            tbpControl.ResumeLayout(false);
            tbpControl.PerformLayout();
            tbpMemSerch.ResumeLayout(false);
            tbpMemSerch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ProductCard productCard8;
        private ProductCard productCard7;
        private ProductCard productCard6;
        private ProductCard productCard5;
        private ProductCard productCard4;
        private ProductCard productCard3;
        private ProductCard productCard2;
        private ProductCard productCard1;
        private TabPage tabPage2;
        private Label label1;
        private TabControl tabControl2;
        private TabPage tbpControl;
        private Label lbAddP_description;
        private Label lbAddP_stock;
        private Label lbAddP_origin;
        private Label lbAddP_weight;
        private Label lbAddP_price;
        private Label lbAddP_category;
        private Label lbAddP_name;
        private TabPage tbpMemSerch;
        private ComboBox cbAddP_category;
        private RichTextBox rtbAddP_description;
        private TextBox txbAddP_weight;
        private TextBox txbAddP_price;
        private TextBox txbAddP_name;
        private Button btnAddProduct;
        private ComboBox cbAddP_stock;
        private Button btntest;
        private Button btnAddOriginType;
        private ComboBox cbAddP_origin;
        private Label label2;
        private Button cbAddCategoryType;
        private Label lbPage;
        private ComboBox cbPage;
        private Button btnBackPage;
        private Button btnNextPage;
        private ComboBox comboBox1;
        private TextBox txbS_Name;
        private Label label3;
        private TextBox txbS_Price;
        private Label label5;
        private Label label4;
        private Label label7;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private Label label6;
        private Button button2;
        private Button button1;
        private ComboBox comboBox2;
    }
}
