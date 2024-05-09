﻿using System.Windows.Forms;

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
            tbcProdut = new TabControl();
            tbProduct = new TabPage();
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
            tbAddProduct = new TabPage();
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
            tbMemSerch = new TabPage();
            pictureBox1 = new PictureBox();
            ptb_Buy = new PictureBox();
            txbTotal = new TextBox();
            flp_shoppingCar = new FlowLayoutPanel();
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
            btntest = new Button();
            tbcControl = new TabControl();
            tbMenberEdit = new TabPage();
            btnAccountEdit = new Button();
            btnMemberEdit = new Button();
            ptbAccount = new PictureBox();
            ptbMember = new PictureBox();
            txbOldPassword = new TextBox();
            lbOldPassword = new Label();
            txbCheck = new TextBox();
            lbCheck = new Label();
            txbPassword = new TextBox();
            lbPassword = new Label();
            lbMem_Title2 = new Label();
            txbMem_Address = new TextBox();
            lbMem_Address = new Label();
            txbMem_Email = new TextBox();
            lbMem_Email = new Label();
            txbMem_Phone = new TextBox();
            lbMem_Phone = new Label();
            lbMem_Title = new Label();
            txbMem_Name = new TextBox();
            lbMem_Name = new Label();
            btn_Login = new Button();
            lbMember = new Label();
            tbcProdut.SuspendLayout();
            tbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Sort).BeginInit();
            tbAddProduct.SuspendLayout();
            tbMemSerch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Buy).BeginInit();
            tbcControl.SuspendLayout();
            tbMenberEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMember).BeginInit();
            SuspendLayout();
            // 
            // tbcProdut
            // 
            tbcProdut.Controls.Add(tbProduct);
            tbcProdut.Location = new Point(28, 49);
            tbcProdut.Name = "tbcProdut";
            tbcProdut.SelectedIndex = 0;
            tbcProdut.Size = new Size(1084, 782);
            tbcProdut.TabIndex = 8;
            tbcProdut.Tag = "";
            // 
            // tbProduct
            // 
            tbProduct.BorderStyle = BorderStyle.FixedSingle;
            tbProduct.Controls.Add(ptb_Sort);
            tbProduct.Controls.Add(cb_Sort);
            tbProduct.Controls.Add(lb_Sort2);
            tbProduct.Controls.Add(lb_Sort);
            tbProduct.Controls.Add(lbPage);
            tbProduct.Controls.Add(cbPage);
            tbProduct.Controls.Add(btnBackPage);
            tbProduct.Controls.Add(btnNextPage);
            tbProduct.Controls.Add(productCard8);
            tbProduct.Controls.Add(productCard7);
            tbProduct.Controls.Add(productCard6);
            tbProduct.Controls.Add(productCard5);
            tbProduct.Controls.Add(productCard4);
            tbProduct.Controls.Add(productCard3);
            tbProduct.Controls.Add(productCard2);
            tbProduct.Controls.Add(productCard1);
            tbProduct.Location = new Point(4, 24);
            tbProduct.Name = "tbProduct";
            tbProduct.Padding = new Padding(3);
            tbProduct.Size = new Size(1076, 754);
            tbProduct.TabIndex = 0;
            tbProduct.Tag = "4";
            tbProduct.Text = "商品";
            tbProduct.UseVisualStyleBackColor = true;
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
            // tbAddProduct
            // 
            tbAddProduct.BorderStyle = BorderStyle.FixedSingle;
            tbAddProduct.Controls.Add(cbAddCategoryType);
            tbAddProduct.Controls.Add(txbAddP_name);
            tbAddProduct.Controls.Add(txbAddP_price);
            tbAddProduct.Controls.Add(cbAddP_category);
            tbAddProduct.Controls.Add(txbAddP_weight);
            tbAddProduct.Controls.Add(rtbAddP_description);
            tbAddProduct.Controls.Add(label2);
            tbAddProduct.Controls.Add(lbAddP_description);
            tbAddProduct.Controls.Add(cbAddP_origin);
            tbAddProduct.Controls.Add(lbAddP_stock);
            tbAddProduct.Controls.Add(cbAddP_stock);
            tbAddProduct.Controls.Add(lbAddP_origin);
            tbAddProduct.Controls.Add(lbAddP_name);
            tbAddProduct.Controls.Add(btnAddProduct);
            tbAddProduct.Controls.Add(lbAddP_weight);
            tbAddProduct.Controls.Add(lbAddP_category);
            tbAddProduct.Controls.Add(btnAddOriginType);
            tbAddProduct.Controls.Add(lbAddP_price);
            tbAddProduct.Location = new Point(4, 24);
            tbAddProduct.Name = "tbAddProduct";
            tbAddProduct.Padding = new Padding(3);
            tbAddProduct.Size = new Size(462, 754);
            tbAddProduct.TabIndex = 0;
            tbAddProduct.Tag = "2";
            tbAddProduct.Text = "管理者";
            tbAddProduct.UseVisualStyleBackColor = true;
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
            txbAddP_price.KeyPress += checkNum_KeyPress;
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
            txbAddP_weight.KeyPress += checkNum_KeyPress;
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
            // tbMemSerch
            // 
            tbMemSerch.Controls.Add(pictureBox1);
            tbMemSerch.Controls.Add(ptb_Buy);
            tbMemSerch.Controls.Add(txbTotal);
            tbMemSerch.Controls.Add(flp_shoppingCar);
            tbMemSerch.Controls.Add(btnS_Clear);
            tbMemSerch.Controls.Add(btnS_Search);
            tbMemSerch.Controls.Add(cbS_Origin);
            tbMemSerch.Controls.Add(lbS_Origin);
            tbMemSerch.Controls.Add(cbS_Category);
            tbMemSerch.Controls.Add(btnS_WeightToggle);
            tbMemSerch.Controls.Add(txbS_weight);
            tbMemSerch.Controls.Add(txbS_Price);
            tbMemSerch.Controls.Add(txbS_Name);
            tbMemSerch.Controls.Add(lbS_Weight);
            tbMemSerch.Controls.Add(btnS_PriceToggle);
            tbMemSerch.Controls.Add(lbS_Price);
            tbMemSerch.Controls.Add(lbS_Category);
            tbMemSerch.Controls.Add(lbS_Name);
            tbMemSerch.Location = new Point(4, 24);
            tbMemSerch.Name = "tbMemSerch";
            tbMemSerch.Padding = new Padding(3);
            tbMemSerch.Size = new Size(462, 754);
            tbMemSerch.TabIndex = 1;
            tbMemSerch.Tag = "4";
            tbMemSerch.Text = "商品查詢";
            tbMemSerch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.loupe;
            pictureBox1.Location = new Point(353, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 74);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // ptb_Buy
            // 
            ptb_Buy.Cursor = Cursors.Hand;
            ptb_Buy.Enabled = false;
            ptb_Buy.Image = Properties.Resources.buy;
            ptb_Buy.Location = new Point(343, 702);
            ptb_Buy.Name = "ptb_Buy";
            ptb_Buy.Padding = new Padding(3);
            ptb_Buy.Size = new Size(94, 52);
            ptb_Buy.TabIndex = 35;
            ptb_Buy.TabStop = false;
            ptb_Buy.Visible = false;
            ptb_Buy.Click += ptb_Buy_Click;
            // 
            // txbTotal
            // 
            txbTotal.BackColor = SystemColors.Window;
            txbTotal.BorderStyle = BorderStyle.None;
            txbTotal.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbTotal.Location = new Point(6, 717);
            txbTotal.Name = "txbTotal";
            txbTotal.Size = new Size(207, 31);
            txbTotal.TabIndex = 34;
            txbTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // flp_shoppingCar
            // 
            flp_shoppingCar.AutoScroll = true;
            flp_shoppingCar.BackgroundImage = Properties.Resources.shopping_cart2;
            flp_shoppingCar.BackgroundImageLayout = ImageLayout.Center;
            flp_shoppingCar.BorderStyle = BorderStyle.FixedSingle;
            flp_shoppingCar.Location = new Point(6, 269);
            flp_shoppingCar.Name = "flp_shoppingCar";
            flp_shoppingCar.Size = new Size(431, 433);
            flp_shoppingCar.TabIndex = 31;
            flp_shoppingCar.ControlAdded += flp_shoppingCar_ControlChange;
            flp_shoppingCar.ControlRemoved += flp_shoppingCar_ControlChange;
            // 
            // btnS_Clear
            // 
            btnS_Clear.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnS_Clear.Location = new Point(360, 207);
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
            btnS_Search.Location = new Point(360, 155);
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
            cbS_Origin.Location = new Point(110, 227);
            cbS_Origin.Name = "cbS_Origin";
            cbS_Origin.Size = new Size(170, 23);
            cbS_Origin.TabIndex = 28;
            // 
            // lbS_Origin
            // 
            lbS_Origin.AutoEllipsis = true;
            lbS_Origin.AutoSize = true;
            lbS_Origin.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbS_Origin.Location = new Point(29, 227);
            lbS_Origin.Name = "lbS_Origin";
            lbS_Origin.Size = new Size(48, 24);
            lbS_Origin.TabIndex = 27;
            lbS_Origin.Text = "產地";
            // 
            // cbS_Category
            // 
            cbS_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cbS_Category.FormattingEnabled = true;
            cbS_Category.Location = new Point(110, 74);
            cbS_Category.Name = "cbS_Category";
            cbS_Category.Size = new Size(170, 23);
            cbS_Category.TabIndex = 10;
            // 
            // btnS_WeightToggle
            // 
            btnS_WeightToggle.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnS_WeightToggle.Location = new Point(286, 175);
            btnS_WeightToggle.Name = "btnS_WeightToggle";
            btnS_WeightToggle.Size = new Size(47, 23);
            btnS_WeightToggle.TabIndex = 25;
            btnS_WeightToggle.Text = "以上";
            btnS_WeightToggle.UseVisualStyleBackColor = true;
            btnS_WeightToggle.Click += btnS_WeightToggle_Click;
            // 
            // txbS_weight
            // 
            txbS_weight.Location = new Point(110, 174);
            txbS_weight.MaxLength = 8;
            txbS_weight.Name = "txbS_weight";
            txbS_weight.Size = new Size(170, 23);
            txbS_weight.TabIndex = 24;
            txbS_weight.KeyPress += checkNum_KeyPress;
            // 
            // txbS_Price
            // 
            txbS_Price.Location = new Point(110, 123);
            txbS_Price.MaxLength = 8;
            txbS_Price.Name = "txbS_Price";
            txbS_Price.Size = new Size(170, 23);
            txbS_Price.TabIndex = 13;
            txbS_Price.KeyPress += checkNum_KeyPress;
            // 
            // txbS_Name
            // 
            txbS_Name.Location = new Point(110, 20);
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
            lbS_Weight.Location = new Point(29, 174);
            lbS_Weight.Name = "lbS_Weight";
            lbS_Weight.Size = new Size(48, 24);
            lbS_Weight.TabIndex = 23;
            lbS_Weight.Text = "重量";
            // 
            // btnS_PriceToggle
            // 
            btnS_PriceToggle.BackColor = Color.Transparent;
            btnS_PriceToggle.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnS_PriceToggle.Location = new Point(286, 123);
            btnS_PriceToggle.Name = "btnS_PriceToggle";
            btnS_PriceToggle.Size = new Size(47, 23);
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
            lbS_Price.Location = new Point(29, 122);
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
            lbS_Category.Location = new Point(29, 70);
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
            lbS_Name.Location = new Point(29, 20);
            lbS_Name.Name = "lbS_Name";
            lbS_Name.Size = new Size(48, 24);
            lbS_Name.TabIndex = 1;
            lbS_Name.Text = "名稱";
            // 
            // btntest
            // 
            btntest.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btntest.Location = new Point(859, 14);
            btntest.Name = "btntest";
            btntest.Size = new Size(96, 43);
            btntest.TabIndex = 32;
            btntest.Text = "測試";
            btntest.UseVisualStyleBackColor = true;
            btntest.Click += btntest_Click_1;
            // 
            // tbcControl
            // 
            tbcControl.Controls.Add(tbMemSerch);
            tbcControl.Controls.Add(tbAddProduct);
            tbcControl.Controls.Add(tbMenberEdit);
            tbcControl.Location = new Point(1114, 49);
            tbcControl.Name = "tbcControl";
            tbcControl.SelectedIndex = 0;
            tbcControl.Size = new Size(470, 782);
            tbcControl.TabIndex = 10;
            tbcControl.Tag = "";
            // 
            // tbMenberEdit
            // 
            tbMenberEdit.Controls.Add(btnAccountEdit);
            tbMenberEdit.Controls.Add(btnMemberEdit);
            tbMenberEdit.Controls.Add(ptbAccount);
            tbMenberEdit.Controls.Add(ptbMember);
            tbMenberEdit.Controls.Add(txbOldPassword);
            tbMenberEdit.Controls.Add(lbOldPassword);
            tbMenberEdit.Controls.Add(txbCheck);
            tbMenberEdit.Controls.Add(lbCheck);
            tbMenberEdit.Controls.Add(txbPassword);
            tbMenberEdit.Controls.Add(lbPassword);
            tbMenberEdit.Controls.Add(lbMem_Title2);
            tbMenberEdit.Controls.Add(txbMem_Address);
            tbMenberEdit.Controls.Add(lbMem_Address);
            tbMenberEdit.Controls.Add(txbMem_Email);
            tbMenberEdit.Controls.Add(lbMem_Email);
            tbMenberEdit.Controls.Add(txbMem_Phone);
            tbMenberEdit.Controls.Add(lbMem_Phone);
            tbMenberEdit.Controls.Add(lbMem_Title);
            tbMenberEdit.Controls.Add(txbMem_Name);
            tbMenberEdit.Controls.Add(lbMem_Name);
            tbMenberEdit.Location = new Point(4, 24);
            tbMenberEdit.Name = "tbMenberEdit";
            tbMenberEdit.Padding = new Padding(3);
            tbMenberEdit.Size = new Size(462, 754);
            tbMenberEdit.TabIndex = 2;
            tbMenberEdit.Tag = "3";
            tbMenberEdit.Text = "基本資料";
            tbMenberEdit.UseVisualStyleBackColor = true;
            // 
            // btnAccountEdit
            // 
            btnAccountEdit.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnAccountEdit.Location = new Point(324, 687);
            btnAccountEdit.Name = "btnAccountEdit";
            btnAccountEdit.Size = new Size(96, 43);
            btnAccountEdit.TabIndex = 34;
            btnAccountEdit.Text = "更改密碼";
            btnAccountEdit.UseVisualStyleBackColor = true;
            // 
            // btnMemberEdit
            // 
            btnMemberEdit.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnMemberEdit.Location = new Point(304, 342);
            btnMemberEdit.Name = "btnMemberEdit";
            btnMemberEdit.Size = new Size(116, 43);
            btnMemberEdit.TabIndex = 33;
            btnMemberEdit.Text = "更改會員資料";
            btnMemberEdit.UseVisualStyleBackColor = true;
            btnMemberEdit.Click += btnMemberEdit_Click;
            // 
            // ptbAccount
            // 
            ptbAccount.Image = Properties.Resources.account;
            ptbAccount.Location = new Point(290, 405);
            ptbAccount.Name = "ptbAccount";
            ptbAccount.Size = new Size(130, 118);
            ptbAccount.TabIndex = 26;
            ptbAccount.TabStop = false;
            // 
            // ptbMember
            // 
            ptbMember.Image = Properties.Resources.membership;
            ptbMember.Location = new Point(290, 3);
            ptbMember.Name = "ptbMember";
            ptbMember.Size = new Size(142, 130);
            ptbMember.TabIndex = 25;
            ptbMember.TabStop = false;
            // 
            // txbOldPassword
            // 
            txbOldPassword.Location = new Point(143, 529);
            txbOldPassword.MaxLength = 30;
            txbOldPassword.Name = "txbOldPassword";
            txbOldPassword.Size = new Size(170, 23);
            txbOldPassword.TabIndex = 24;
            // 
            // lbOldPassword
            // 
            lbOldPassword.AutoEllipsis = true;
            lbOldPassword.AutoSize = true;
            lbOldPassword.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOldPassword.Location = new Point(59, 528);
            lbOldPassword.Name = "lbOldPassword";
            lbOldPassword.Size = new Size(67, 24);
            lbOldPassword.TabIndex = 23;
            lbOldPassword.Text = "舊密碼";
            // 
            // txbCheck
            // 
            txbCheck.Location = new Point(143, 644);
            txbCheck.MaxLength = 30;
            txbCheck.Name = "txbCheck";
            txbCheck.Size = new Size(170, 23);
            txbCheck.TabIndex = 22;
            // 
            // lbCheck
            // 
            lbCheck.AutoEllipsis = true;
            lbCheck.AutoSize = true;
            lbCheck.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbCheck.Location = new Point(78, 644);
            lbCheck.Name = "lbCheck";
            lbCheck.Size = new Size(48, 24);
            lbCheck.TabIndex = 21;
            lbCheck.Text = "地址";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(143, 586);
            txbPassword.MaxLength = 30;
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(170, 23);
            txbPassword.TabIndex = 20;
            // 
            // lbPassword
            // 
            lbPassword.AutoEllipsis = true;
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbPassword.Location = new Point(78, 586);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(48, 24);
            lbPassword.TabIndex = 19;
            lbPassword.Text = "地址";
            // 
            // lbMem_Title2
            // 
            lbMem_Title2.AutoSize = true;
            lbMem_Title2.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbMem_Title2.Location = new Point(59, 436);
            lbMem_Title2.Name = "lbMem_Title2";
            lbMem_Title2.Size = new Size(146, 41);
            lbMem_Title2.TabIndex = 18;
            lbMem_Title2.Text = "帳號設定";
            // 
            // txbMem_Address
            // 
            txbMem_Address.Location = new Point(143, 296);
            txbMem_Address.MaxLength = 30;
            txbMem_Address.Name = "txbMem_Address";
            txbMem_Address.Size = new Size(170, 23);
            txbMem_Address.TabIndex = 17;
            // 
            // lbMem_Address
            // 
            lbMem_Address.AutoEllipsis = true;
            lbMem_Address.AutoSize = true;
            lbMem_Address.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMem_Address.Location = new Point(78, 296);
            lbMem_Address.Name = "lbMem_Address";
            lbMem_Address.Size = new Size(48, 24);
            lbMem_Address.TabIndex = 16;
            lbMem_Address.Text = "地址";
            // 
            // txbMem_Email
            // 
            txbMem_Email.Location = new Point(143, 246);
            txbMem_Email.MaxLength = 30;
            txbMem_Email.Name = "txbMem_Email";
            txbMem_Email.Size = new Size(170, 23);
            txbMem_Email.TabIndex = 15;
            // 
            // lbMem_Email
            // 
            lbMem_Email.AutoEllipsis = true;
            lbMem_Email.AutoSize = true;
            lbMem_Email.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMem_Email.Location = new Point(59, 246);
            lbMem_Email.Name = "lbMem_Email";
            lbMem_Email.Size = new Size(67, 24);
            lbMem_Email.TabIndex = 14;
            lbMem_Email.Text = "e-mail";
            // 
            // txbMem_Phone
            // 
            txbMem_Phone.Location = new Point(143, 193);
            txbMem_Phone.MaxLength = 10;
            txbMem_Phone.Name = "txbMem_Phone";
            txbMem_Phone.Size = new Size(170, 23);
            txbMem_Phone.TabIndex = 13;
            txbMem_Phone.KeyPress += checkNum_KeyPress;
            // 
            // lbMem_Phone
            // 
            lbMem_Phone.AutoEllipsis = true;
            lbMem_Phone.AutoSize = true;
            lbMem_Phone.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMem_Phone.Location = new Point(78, 193);
            lbMem_Phone.Name = "lbMem_Phone";
            lbMem_Phone.Size = new Size(48, 24);
            lbMem_Phone.TabIndex = 12;
            lbMem_Phone.Text = "電話";
            // 
            // lbMem_Title
            // 
            lbMem_Title.AutoSize = true;
            lbMem_Title.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbMem_Title.Location = new Point(59, 58);
            lbMem_Title.Name = "lbMem_Title";
            lbMem_Title.Size = new Size(146, 41);
            lbMem_Title.TabIndex = 11;
            lbMem_Title.Text = "基本資料";
            // 
            // txbMem_Name
            // 
            txbMem_Name.Location = new Point(143, 138);
            txbMem_Name.MaxLength = 30;
            txbMem_Name.Name = "txbMem_Name";
            txbMem_Name.Size = new Size(170, 23);
            txbMem_Name.TabIndex = 10;
            // 
            // lbMem_Name
            // 
            lbMem_Name.AutoEllipsis = true;
            lbMem_Name.AutoSize = true;
            lbMem_Name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMem_Name.Location = new Point(78, 138);
            lbMem_Name.Name = "lbMem_Name";
            lbMem_Name.Size = new Size(48, 24);
            lbMem_Name.TabIndex = 9;
            lbMem_Name.Text = "名稱";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.GradientActiveCaption;
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_Login.Location = new Point(1442, 14);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(96, 43);
            btn_Login.TabIndex = 30;
            btn_Login.Text = "註冊/登入";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // lbMember
            // 
            lbMember.AutoEllipsis = true;
            lbMember.AutoSize = true;
            lbMember.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 136);
            lbMember.Location = new Point(1244, 20);
            lbMember.Name = "lbMember";
            lbMember.Size = new Size(0, 26);
            lbMember.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(lbMember);
            Controls.Add(btn_Login);
            Controls.Add(btntest);
            Controls.Add(tbcControl);
            Controls.Add(label1);
            Controls.Add(tbcProdut);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "大港開吃";
            Load += Form1_Load;
            tbcProdut.ResumeLayout(false);
            tbProduct.ResumeLayout(false);
            tbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Sort).EndInit();
            tbAddProduct.ResumeLayout(false);
            tbAddProduct.PerformLayout();
            tbMemSerch.ResumeLayout(false);
            tbMemSerch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Buy).EndInit();
            tbcControl.ResumeLayout(false);
            tbMenberEdit.ResumeLayout(false);
            tbMenberEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ProductCard8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tbcProdut;
        private TabPage tbProduct;
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
        private TabPage tbAddProduct;
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
        private TabPage tbMemSerch;
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
        private TabControl tbcControl;
        private Button btnS_Search;
        private Button btnS_Clear;
        private Label lb_Sort;
        private ComboBox cb_Sort;
        private Label lb_Sort2;
        private PictureBox ptb_Sort;
        private FlowLayoutPanel flp_shoppingCar;
        private Button btn_Login;
        private Label lbMember;
        private Button btntest;
        private TextBox txbTotal;
        private PictureBox ptb_Buy;
        private TabPage tbMenberEdit;
        private PictureBox pictureBox1;
        private TextBox txbMem_Name;
        private Label lbMem_Name;
        private TextBox txbMem_Phone;
        private Label lbMem_Phone;
        private Label lbMem_Title;
        private Label lbMem_Title2;
        private TextBox txbMem_Address;
        private Label lbMem_Address;
        private TextBox txbMem_Email;
        private Label lbMem_Email;
        private TextBox txbCheck;
        private Label lbCheck;
        private TextBox txbPassword;
        private Label lbPassword;
        private TextBox txbOldPassword;
        private Label lbOldPassword;
        private PictureBox ptbAccount;
        private PictureBox ptbMember;
        private Button btnMemberEdit;
        private Button btnAccountEdit;
    }
}
