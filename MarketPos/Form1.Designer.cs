using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tbcProduct = new TabPage();
            ptb_Sort = new PictureBox();
            cb_Sort = new ComboBox();
            lb_Sort2 = new Label();
            lb_Sort = new Label();
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
            label1 = new Label();
            tbpControl = new TabPage();
            cbAddCategoryType = new Button();
            txbAddP_name = new TextBox();
            txbAddP_price = new TextBox();
            cbAddP_category = new ComboBox();
            txbAddP_weight = new TextBox();
            rtbAddP_description = new RichTextBox();
            label2 = new Label();
            lbAddP_description = new Label();
            cbAddP_origin = new ComboBox();
            lbAddP_stock = new Label();
            cbAddP_stock = new ComboBox();
            lbAddP_origin = new Label();
            lbAddP_name = new Label();
            btnAddProduct = new Button();
            lbAddP_weight = new Label();
            lbAddP_category = new Label();
            btnAddOriginType = new Button();
            lbAddP_price = new Label();
            tbpMemSerch = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            shoppingCard1 = new ShoppingCard();
            shoppingCard2 = new ShoppingCard();
            shoppingCard3 = new ShoppingCard();
            shoppingCard4 = new ShoppingCard();
            btnS_Clear = new Button();
            btnS_Search = new Button();
            cbS_Origin = new ComboBox();
            lbS_Origin = new Label();
            cbS_Category = new ComboBox();
            btnS_WeightToggle = new Button();
            txbS_weight = new TextBox();
            txbS_Price = new TextBox();
            txbS_Name = new TextBox();
            lbS_Weight = new Label();
            btnS_PriceToggle = new Button();
            lbS_Price = new Label();
            lbS_Category = new Label();
            lbS_Name = new Label();
            tabControl2 = new TabControl();
            btn_Login = new Button();
            tabControl1.SuspendLayout();
            tbcProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Sort).BeginInit();
            tbpControl.SuspendLayout();
            tbpMemSerch.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabControl2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbcProduct);
            tabControl1.Location = new Point(28, 49);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1084, 782);
            tabControl1.TabIndex = 8;
            // 
            // tbcProduct
            // 
            tbcProduct.BorderStyle = BorderStyle.FixedSingle;
            tbcProduct.Controls.Add(ptb_Sort);
            tbcProduct.Controls.Add(cb_Sort);
            tbcProduct.Controls.Add(lb_Sort2);
            tbcProduct.Controls.Add(lb_Sort);
            tbcProduct.Controls.Add(lbPage);
            tbcProduct.Controls.Add(cbPage);
            tbcProduct.Controls.Add(btnBackPage);
            tbcProduct.Controls.Add(btnNextPage);
            tbcProduct.Controls.Add(productCard8);
            tbcProduct.Controls.Add(productCard7);
            tbcProduct.Controls.Add(productCard6);
            tbcProduct.Controls.Add(productCard5);
            tbcProduct.Controls.Add(productCard4);
            tbcProduct.Controls.Add(productCard3);
            tbcProduct.Controls.Add(productCard2);
            tbcProduct.Controls.Add(productCard1);
            tbcProduct.Location = new Point(4, 24);
            tbcProduct.Name = "tbcProduct";
            tbcProduct.Padding = new Padding(3);
            tbcProduct.Size = new Size(1076, 754);
            tbcProduct.TabIndex = 0;
            tbcProduct.Text = "商品";
            tbcProduct.UseVisualStyleBackColor = true;
            // 
            // ptb_Sort
            // 
            ptb_Sort.BackgroundImageLayout = ImageLayout.Stretch;
            ptb_Sort.Cursor = Cursors.Hand;
            ptb_Sort.Image = Properties.Resources.descendingOrder;
            ptb_Sort.Location = new Point(671, 690);
            ptb_Sort.Name = "ptb_Sort";
            ptb_Sort.Size = new Size(32, 32);
            ptb_Sort.TabIndex = 30;
            ptb_Sort.TabStop = false;
            ptb_Sort.Tag = "descendingOrder";
            ptb_Sort.Click += ptb_Sort_Click;
            // 
            // cb_Sort
            // 
            cb_Sort.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Sort.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cb_Sort.FormattingEnabled = true;
            cb_Sort.Items.AddRange(new object[] { "名稱", "種類", "價格", "重量", "產地" });
            cb_Sort.Location = new Point(522, 690);
            cb_Sort.Name = "cb_Sort";
            cb_Sort.Size = new Size(89, 32);
            cb_Sort.TabIndex = 29;
            // 
            // lb_Sort2
            // 
            lb_Sort2.AutoEllipsis = true;
            lb_Sort2.AutoSize = true;
            lb_Sort2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lb_Sort2.Location = new Point(617, 693);
            lb_Sort2.Name = "lb_Sort2";
            lb_Sort2.Size = new Size(48, 24);
            lb_Sort2.TabIndex = 22;
            lb_Sort2.Text = "排序";
            // 
            // lb_Sort
            // 
            lb_Sort.AutoEllipsis = true;
            lb_Sort.AutoSize = true;
            lb_Sort.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lb_Sort.Location = new Point(468, 693);
            lb_Sort.Name = "lb_Sort";
            lb_Sort.Size = new Size(48, 24);
            lb_Sort.TabIndex = 21;
            lb_Sort.Text = "依照";
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
            cbPage.BackColor = SystemColors.Window;
            cbPage.DropDownStyle = ComboBoxStyle.DropDownList;
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
            // tbpControl
            // 
            tbpControl.BorderStyle = BorderStyle.FixedSingle;
            tbpControl.Controls.Add(cbAddCategoryType);
            tbpControl.Controls.Add(txbAddP_name);
            tbpControl.Controls.Add(txbAddP_price);
            tbpControl.Controls.Add(cbAddP_category);
            tbpControl.Controls.Add(txbAddP_weight);
            tbpControl.Controls.Add(rtbAddP_description);
            tbpControl.Controls.Add(label2);
            tbpControl.Controls.Add(lbAddP_description);
            tbpControl.Controls.Add(cbAddP_origin);
            tbpControl.Controls.Add(lbAddP_stock);
            tbpControl.Controls.Add(cbAddP_stock);
            tbpControl.Controls.Add(lbAddP_origin);
            tbpControl.Controls.Add(lbAddP_name);
            tbpControl.Controls.Add(btnAddProduct);
            tbpControl.Controls.Add(lbAddP_weight);
            tbpControl.Controls.Add(lbAddP_category);
            tbpControl.Controls.Add(btnAddOriginType);
            tbpControl.Controls.Add(lbAddP_price);
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
            cbAddCategoryType.Location = new Point(297, 141);
            cbAddCategoryType.Name = "cbAddCategoryType";
            cbAddCategoryType.Size = new Size(63, 25);
            cbAddCategoryType.TabIndex = 20;
            cbAddCategoryType.Text = "新增類別";
            cbAddCategoryType.UseVisualStyleBackColor = true;
            cbAddCategoryType.Click += cbAddCategoryType_Click;
            // 
            // txbAddP_name
            // 
            txbAddP_name.Location = new Point(112, 82);
            txbAddP_name.MaxLength = 30;
            txbAddP_name.Name = "txbAddP_name";
            txbAddP_name.Size = new Size(170, 23);
            txbAddP_name.TabIndex = 8;
            // 
            // txbAddP_price
            // 
            txbAddP_price.Location = new Point(112, 203);
            txbAddP_price.MaxLength = 8;
            txbAddP_price.Name = "txbAddP_price";
            txbAddP_price.Size = new Size(170, 23);
            txbAddP_price.TabIndex = 9;
            txbAddP_price.KeyPress += check_KeyPress;
            // 
            // cbAddP_category
            // 
            cbAddP_category.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAddP_category.FormattingEnabled = true;
            cbAddP_category.Location = new Point(112, 143);
            cbAddP_category.Name = "cbAddP_category";
            cbAddP_category.Size = new Size(170, 23);
            cbAddP_category.TabIndex = 7;
            // 
            // txbAddP_weight
            // 
            txbAddP_weight.Location = new Point(112, 263);
            txbAddP_weight.MaxLength = 8;
            txbAddP_weight.Name = "txbAddP_weight";
            txbAddP_weight.Size = new Size(170, 23);
            txbAddP_weight.TabIndex = 10;
            txbAddP_weight.KeyPress += check_KeyPress;
            // 
            // rtbAddP_description
            // 
            rtbAddP_description.Location = new Point(121, 439);
            rtbAddP_description.Name = "rtbAddP_description";
            rtbAddP_description.Size = new Size(319, 192);
            rtbAddP_description.TabIndex = 13;
            rtbAddP_description.Text = "";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(288, 268);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 19;
            label2.Text = "公克(g)";
            // 
            // lbAddP_description
            // 
            lbAddP_description.AutoEllipsis = true;
            lbAddP_description.AutoSize = true;
            lbAddP_description.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_description.Location = new Point(47, 435);
            lbAddP_description.Name = "lbAddP_description";
            lbAddP_description.Size = new Size(48, 24);
            lbAddP_description.TabIndex = 6;
            lbAddP_description.Text = "描述";
            // 
            // cbAddP_origin
            // 
            cbAddP_origin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAddP_origin.FormattingEnabled = true;
            cbAddP_origin.Location = new Point(112, 323);
            cbAddP_origin.Name = "cbAddP_origin";
            cbAddP_origin.Size = new Size(170, 23);
            cbAddP_origin.TabIndex = 18;
            // 
            // lbAddP_stock
            // 
            lbAddP_stock.AutoEllipsis = true;
            lbAddP_stock.AutoSize = true;
            lbAddP_stock.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_stock.Location = new Point(47, 377);
            lbAddP_stock.Name = "lbAddP_stock";
            lbAddP_stock.Size = new Size(48, 24);
            lbAddP_stock.TabIndex = 5;
            lbAddP_stock.Text = "庫存";
            // 
            // cbAddP_stock
            // 
            cbAddP_stock.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAddP_stock.FormattingEnabled = true;
            cbAddP_stock.ImeMode = ImeMode.NoControl;
            cbAddP_stock.Location = new Point(112, 378);
            cbAddP_stock.Name = "cbAddP_stock";
            cbAddP_stock.Size = new Size(170, 23);
            cbAddP_stock.TabIndex = 15;
            // 
            // lbAddP_origin
            // 
            lbAddP_origin.AutoEllipsis = true;
            lbAddP_origin.AutoSize = true;
            lbAddP_origin.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_origin.Location = new Point(47, 322);
            lbAddP_origin.Name = "lbAddP_origin";
            lbAddP_origin.Size = new Size(48, 24);
            lbAddP_origin.TabIndex = 4;
            lbAddP_origin.Text = "產地";
            // 
            // lbAddP_name
            // 
            lbAddP_name.AutoEllipsis = true;
            lbAddP_name.AutoSize = true;
            lbAddP_name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_name.Location = new Point(47, 82);
            lbAddP_name.Name = "lbAddP_name";
            lbAddP_name.Size = new Size(48, 24);
            lbAddP_name.TabIndex = 0;
            lbAddP_name.Text = "名稱";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnAddProduct.Location = new Point(344, 652);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(96, 43);
            btnAddProduct.TabIndex = 14;
            btnAddProduct.Text = "新增商品";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lbAddP_weight
            // 
            lbAddP_weight.AutoEllipsis = true;
            lbAddP_weight.AutoSize = true;
            lbAddP_weight.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_weight.Location = new Point(47, 263);
            lbAddP_weight.Name = "lbAddP_weight";
            lbAddP_weight.Size = new Size(48, 24);
            lbAddP_weight.TabIndex = 3;
            lbAddP_weight.Text = "重量";
            // 
            // lbAddP_category
            // 
            lbAddP_category.AutoEllipsis = true;
            lbAddP_category.AutoSize = true;
            lbAddP_category.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_category.Location = new Point(47, 141);
            lbAddP_category.Name = "lbAddP_category";
            lbAddP_category.Size = new Size(48, 24);
            lbAddP_category.TabIndex = 1;
            lbAddP_category.Text = "種類";
            // 
            // btnAddOriginType
            // 
            btnAddOriginType.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnAddOriginType.Location = new Point(297, 322);
            btnAddOriginType.Name = "btnAddOriginType";
            btnAddOriginType.Size = new Size(63, 25);
            btnAddOriginType.TabIndex = 17;
            btnAddOriginType.Text = "新增產地";
            btnAddOriginType.UseVisualStyleBackColor = true;
            btnAddOriginType.Click += btnAddOriginType_Click;
            // 
            // lbAddP_price
            // 
            lbAddP_price.AutoEllipsis = true;
            lbAddP_price.AutoSize = true;
            lbAddP_price.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbAddP_price.Location = new Point(47, 203);
            lbAddP_price.Name = "lbAddP_price";
            lbAddP_price.Size = new Size(48, 24);
            lbAddP_price.TabIndex = 2;
            lbAddP_price.Text = "價格";
            // 
            // tbpMemSerch
            // 
            tbpMemSerch.Controls.Add(flowLayoutPanel1);
            tbpMemSerch.Controls.Add(btnS_Clear);
            tbpMemSerch.Controls.Add(btnS_Search);
            tbpMemSerch.Controls.Add(cbS_Origin);
            tbpMemSerch.Controls.Add(lbS_Origin);
            tbpMemSerch.Controls.Add(cbS_Category);
            tbpMemSerch.Controls.Add(btnS_WeightToggle);
            tbpMemSerch.Controls.Add(txbS_weight);
            tbpMemSerch.Controls.Add(txbS_Price);
            tbpMemSerch.Controls.Add(txbS_Name);
            tbpMemSerch.Controls.Add(lbS_Weight);
            tbpMemSerch.Controls.Add(btnS_PriceToggle);
            tbpMemSerch.Controls.Add(lbS_Price);
            tbpMemSerch.Controls.Add(lbS_Category);
            tbpMemSerch.Controls.Add(lbS_Name);
            tbpMemSerch.Location = new Point(4, 24);
            tbpMemSerch.Name = "tbpMemSerch";
            tbpMemSerch.Padding = new Padding(3);
            tbpMemSerch.Size = new Size(462, 754);
            tbpMemSerch.TabIndex = 1;
            tbpMemSerch.Text = "商品查詢";
            tbpMemSerch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(shoppingCard1);
            flowLayoutPanel1.Controls.Add(shoppingCard2);
            flowLayoutPanel1.Controls.Add(shoppingCard3);
            flowLayoutPanel1.Controls.Add(shoppingCard4);
            flowLayoutPanel1.Location = new Point(6, 371);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(431, 377);
            flowLayoutPanel1.TabIndex = 31;
            // 
            // shoppingCard1
            // 
            shoppingCard1.BackColor = SystemColors.Menu;
            shoppingCard1.BorderStyle = BorderStyle.FixedSingle;
            shoppingCard1.Location = new Point(3, 3);
            shoppingCard1.Name = "shoppingCard1";
            shoppingCard1.Size = new Size(410, 91);
            shoppingCard1.TabIndex = 0;
            // 
            // shoppingCard2
            // 
            shoppingCard2.BackColor = SystemColors.Menu;
            shoppingCard2.BorderStyle = BorderStyle.FixedSingle;
            shoppingCard2.Location = new Point(3, 100);
            shoppingCard2.Name = "shoppingCard2";
            shoppingCard2.Size = new Size(408, 89);
            shoppingCard2.TabIndex = 1;
            // 
            // shoppingCard3
            // 
            shoppingCard3.BackColor = SystemColors.Menu;
            shoppingCard3.BorderStyle = BorderStyle.FixedSingle;
            shoppingCard3.Location = new Point(3, 195);
            shoppingCard3.Name = "shoppingCard3";
            shoppingCard3.Size = new Size(408, 89);
            shoppingCard3.TabIndex = 2;
            // 
            // shoppingCard4
            // 
            shoppingCard4.BackColor = SystemColors.Menu;
            shoppingCard4.BorderStyle = BorderStyle.FixedSingle;
            shoppingCard4.Location = new Point(3, 290);
            shoppingCard4.Name = "shoppingCard4";
            shoppingCard4.Size = new Size(408, 89);
            shoppingCard4.TabIndex = 3;
            // 
            // btnS_Clear
            // 
            btnS_Clear.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnS_Clear.Location = new Point(200, 303);
            btnS_Clear.Name = "btnS_Clear";
            btnS_Clear.Size = new Size(96, 43);
            btnS_Clear.TabIndex = 30;
            btnS_Clear.Text = "清除條件";
            btnS_Clear.UseVisualStyleBackColor = true;
            btnS_Clear.Click += btnS_Clear_Click;
            // 
            // btnS_Search
            // 
            btnS_Search.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnS_Search.Location = new Point(320, 303);
            btnS_Search.Name = "btnS_Search";
            btnS_Search.Size = new Size(96, 43);
            btnS_Search.TabIndex = 29;
            btnS_Search.Text = "搜尋";
            btnS_Search.UseVisualStyleBackColor = true;
            btnS_Search.Click += btnS_Search_Click;
            // 
            // cbS_Origin
            // 
            cbS_Origin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbS_Origin.FormattingEnabled = true;
            cbS_Origin.Location = new Point(126, 254);
            cbS_Origin.Name = "cbS_Origin";
            cbS_Origin.Size = new Size(170, 23);
            cbS_Origin.TabIndex = 28;
            // 
            // lbS_Origin
            // 
            lbS_Origin.AutoEllipsis = true;
            lbS_Origin.AutoSize = true;
            lbS_Origin.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbS_Origin.Location = new Point(45, 254);
            lbS_Origin.Name = "lbS_Origin";
            lbS_Origin.Size = new Size(48, 24);
            lbS_Origin.TabIndex = 27;
            lbS_Origin.Text = "產地";
            // 
            // cbS_Category
            // 
            cbS_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cbS_Category.FormattingEnabled = true;
            cbS_Category.Location = new Point(126, 101);
            cbS_Category.Name = "cbS_Category";
            cbS_Category.Size = new Size(170, 23);
            cbS_Category.TabIndex = 10;
            // 
            // btnS_WeightToggle
            // 
            btnS_WeightToggle.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnS_WeightToggle.Location = new Point(320, 202);
            btnS_WeightToggle.Name = "btnS_WeightToggle";
            btnS_WeightToggle.Size = new Size(63, 23);
            btnS_WeightToggle.TabIndex = 25;
            btnS_WeightToggle.Text = "以上";
            btnS_WeightToggle.UseVisualStyleBackColor = true;
            btnS_WeightToggle.Click += btnS_WeightToggle_Click;
            // 
            // txbS_weight
            // 
            txbS_weight.Location = new Point(126, 201);
            txbS_weight.MaxLength = 8;
            txbS_weight.Name = "txbS_weight";
            txbS_weight.Size = new Size(170, 23);
            txbS_weight.TabIndex = 24;
            txbS_weight.KeyPress += check_KeyPress;
            // 
            // txbS_Price
            // 
            txbS_Price.Location = new Point(126, 150);
            txbS_Price.MaxLength = 8;
            txbS_Price.Name = "txbS_Price";
            txbS_Price.Size = new Size(170, 23);
            txbS_Price.TabIndex = 13;
            txbS_Price.KeyPress += check_KeyPress;
            // 
            // txbS_Name
            // 
            txbS_Name.Location = new Point(126, 47);
            txbS_Name.MaxLength = 30;
            txbS_Name.Name = "txbS_Name";
            txbS_Name.Size = new Size(170, 23);
            txbS_Name.TabIndex = 9;
            // 
            // lbS_Weight
            // 
            lbS_Weight.AutoEllipsis = true;
            lbS_Weight.AutoSize = true;
            lbS_Weight.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbS_Weight.Location = new Point(45, 201);
            lbS_Weight.Name = "lbS_Weight";
            lbS_Weight.Size = new Size(48, 24);
            lbS_Weight.TabIndex = 23;
            lbS_Weight.Text = "重量";
            // 
            // btnS_PriceToggle
            // 
            btnS_PriceToggle.BackColor = Color.Transparent;
            btnS_PriceToggle.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnS_PriceToggle.Location = new Point(320, 150);
            btnS_PriceToggle.Name = "btnS_PriceToggle";
            btnS_PriceToggle.Size = new Size(63, 23);
            btnS_PriceToggle.TabIndex = 21;
            btnS_PriceToggle.Text = "以上";
            btnS_PriceToggle.UseVisualStyleBackColor = false;
            btnS_PriceToggle.Click += btnS_PriceToggle_Click;
            // 
            // lbS_Price
            // 
            lbS_Price.AutoEllipsis = true;
            lbS_Price.AutoSize = true;
            lbS_Price.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbS_Price.Location = new Point(45, 149);
            lbS_Price.Name = "lbS_Price";
            lbS_Price.Size = new Size(48, 24);
            lbS_Price.TabIndex = 12;
            lbS_Price.Text = "價格";
            // 
            // lbS_Category
            // 
            lbS_Category.AutoEllipsis = true;
            lbS_Category.AutoSize = true;
            lbS_Category.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbS_Category.Location = new Point(45, 97);
            lbS_Category.Name = "lbS_Category";
            lbS_Category.Size = new Size(48, 24);
            lbS_Category.TabIndex = 11;
            lbS_Category.Text = "種類";
            // 
            // lbS_Name
            // 
            lbS_Name.AutoEllipsis = true;
            lbS_Name.AutoSize = true;
            lbS_Name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbS_Name.Location = new Point(45, 47);
            lbS_Name.Name = "lbS_Name";
            lbS_Name.Size = new Size(48, 24);
            lbS_Name.TabIndex = 1;
            lbS_Name.Text = "名稱";
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
            // btn_Login
            // 
            btn_Login.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_Login.Location = new Point(1476, 12);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(96, 43);
            btn_Login.TabIndex = 30;
            btn_Login.Text = "註冊/登入";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(btn_Login);
            Controls.Add(tabControl2);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "大港開吃";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tbcProduct.ResumeLayout(false);
            tbcProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Sort).EndInit();
            tbpControl.ResumeLayout(false);
            tbpControl.PerformLayout();
            tbpMemSerch.ResumeLayout(false);
            tbpMemSerch.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void ProductCard8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbcProduct;
        private ProductCard productCard8;
        private ProductCard productCard7;
        private ProductCard productCard6;
        private ProductCard productCard5;
        private ProductCard productCard4;
        private ProductCard productCard3;
        private ProductCard productCard2;
        private ProductCard productCard1;
        private Label label1;
        private Label lbPage;
        private ComboBox cbPage;
        private Button btnBackPage;
        private Button btnNextPage;
        private TabPage tbpControl;
        private Button cbAddCategoryType;
        private TextBox txbAddP_name;
        private TextBox txbAddP_price;
        private TextBox txbAddP_weight;
        private RichTextBox rtbAddP_description;
        private Label label2;
        private Label lbAddP_description;
        private ComboBox cbAddP_origin;
        private Label lbAddP_stock;
        private ComboBox cbAddP_stock;
        private Label lbAddP_origin;
        private Label lbAddP_name;
        private Button btnAddProduct;
        private ComboBox cbAddP_category;
        private Label lbAddP_weight;
        private Label lbAddP_category;
        private Button btnAddOriginType;
        private Label lbAddP_price;
        private TabPage tbpMemSerch;
        private ComboBox cbS_Origin;
        private Label lbS_Origin;
        private ComboBox cbS_Category;
        private Button btnS_WeightToggle;
        private TextBox txbS_weight;
        private TextBox txbS_Price;
        private TextBox txbS_Name;
        private Label lbS_Weight;
        private Button btnS_PriceToggle;
        private Label lbS_Price;
        private Label lbS_Category;
        private Label lbS_Name;
        private TabControl tabControl2;
        private Button btnS_Search;
        private Button btnS_Clear;
        private Label lb_Sort;
        private ComboBox cb_Sort;
        private Label lb_Sort2;
        private PictureBox ptb_Sort;
        private FlowLayoutPanel flowLayoutPanel1;
        private ShoppingCard shoppingCard1;
        private ShoppingCard shoppingCard2;
        private ShoppingCard shoppingCard3;
        private ShoppingCard shoppingCard4;
        private Button btn_Login;
    }
}
