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
            tbUnshelve = new TabPage();
            lbUnPage = new Label();
            cbUnPage = new ComboBox();
            btnUnBackPage = new Button();
            btnUnNextPage = new Button();
            productCard9 = new ProductCard();
            productCard10 = new ProductCard();
            productCard11 = new ProductCard();
            productCard12 = new ProductCard();
            productCard13 = new ProductCard();
            productCard14 = new ProductCard();
            productCard15 = new ProductCard();
            productCard16 = new ProductCard();
            tbOrderMan = new TabPage();
            ptbMOdr_Confirmed = new PictureBox();
            lbMOdr_Confirmed = new Label();
            ptbMOdr_IsCancel = new PictureBox();
            ptbMOdr_unConfirmed = new PictureBox();
            ptbMOdr_isRead = new PictureBox();
            lbMOdr_unConfirmed = new Label();
            lbMOdr_IsCancel = new Label();
            gbOdrSearch = new GroupBox();
            cbOdrSIsRead = new ComboBox();
            lbOdrSIsRead = new Label();
            btnOdrYear = new Button();
            btnOdrMonth = new Button();
            btnOdrWeek = new Button();
            btnOdrToday = new Button();
            rbtnOdrSName = new RadioButton();
            rbtnOdrSId = new RadioButton();
            ptbOdrSearch = new PictureBox();
            cbOdrSIsConfirmed = new ComboBox();
            lbOdrSIsConfirmed = new Label();
            cbOdrSIsCancel = new ComboBox();
            lbOdrSIsCancel = new Label();
            cbOdrSPayMent = new ComboBox();
            lbOdrSPayMent = new Label();
            cbOdrSProduct = new ComboBox();
            lbOdrSProduct = new Label();
            txbOdrSName = new TextBox();
            lbOdrSName = new Label();
            dtpOdrTime2 = new DateTimePicker();
            lbTime2 = new Label();
            lbTime = new Label();
            btnOdrClear = new Button();
            btnOdrSearch = new Button();
            dtpOdrTime = new DateTimePicker();
            btnMOdrCancel = new Button();
            cbMOdr_Number = new ComboBox();
            lbMOdr_IsRead = new Label();
            lbMOdr_Number = new Label();
            btnMOdrMessage = new Button();
            lbMOdr = new Label();
            btnMOdrConfirmed = new Button();
            flpMOdr = new FlowLayoutPanel();
            ptbMOdr = new PictureBox();
            lbMOdr_Date = new Label();
            txbMOdr_Total = new TextBox();
            txbMOdr_OAddress = new TextBox();
            lbMOdr_RName = new Label();
            lbMOdr_Payment = new Label();
            lbMOdr_OName = new Label();
            lbMOdr_OAddress = new Label();
            lbMOdr_RAddress = new Label();
            txbMOdr_RAddress = new TextBox();
            tbSale = new TabPage();
            btn_test = new Button();
            ptvSL = new OxyPlot.WindowsForms.PlotView();
            lbSale = new Label();
            gbSale = new GroupBox();
            ptbSale = new PictureBox();
            gbSaleY = new GroupBox();
            rbtnSLOrderCount = new RadioButton();
            rbtnSLTatal = new RadioButton();
            rbtnSLQuantity = new RadioButton();
            gbSaleX = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            txbSLMember = new TextBox();
            ckbSLTime1 = new CheckBox();
            rbtnSLCategory = new RadioButton();
            rbtnSLOrigin = new RadioButton();
            rbtnSLMember = new RadioButton();
            rbtnSLProduct = new RadioButton();
            cbSLOrigin = new ComboBox();
            cbSLCategory = new ComboBox();
            label4 = new Label();
            cbSLProduct = new ComboBox();
            btnSLYear = new Button();
            dtpSLTime1 = new DateTimePicker();
            btnSLMonth = new Button();
            lbSLTime2 = new Label();
            btnSLWeek = new Button();
            dtpSLTime2 = new DateTimePicker();
            btnSLToday = new Button();
            btnSLClear = new Button();
            btnSLSearch = new Button();
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
            tbOrderHistory = new TabPage();
            lbOdrIsRead = new Label();
            lbOdrIsConfirmed = new Label();
            btnOdrCancelOdr = new Button();
            btnOdrComment = new Button();
            ptbOdr = new PictureBox();
            txbOdr_Total = new TextBox();
            lbOdr_RName = new Label();
            lbOdr_OName = new Label();
            lbOdr_RAddress = new Label();
            txbOdr_RAdress = new TextBox();
            lbOdr_OAddress = new Label();
            lbOdr_Payment = new Label();
            txbOdr_OAdress = new TextBox();
            lbOdr_date = new Label();
            flpOdr_Histroy = new FlowLayoutPanel();
            lbOdr_Histroy = new Label();
            cbOdr_Number = new ComboBox();
            lbOdr_Number = new Label();
            btn_Login = new Button();
            lbMember = new Label();
            tbcProdut.SuspendLayout();
            tbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Sort).BeginInit();
            tbUnshelve.SuspendLayout();
            tbOrderMan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr_Confirmed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr_IsCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr_unConfirmed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr_isRead).BeginInit();
            gbOdrSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbOdrSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr).BeginInit();
            tbSale.SuspendLayout();
            gbSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSale).BeginInit();
            gbSaleY.SuspendLayout();
            gbSaleX.SuspendLayout();
            tbAddProduct.SuspendLayout();
            tbMemSerch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Buy).BeginInit();
            tbcControl.SuspendLayout();
            tbMenberEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMember).BeginInit();
            tbOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbOdr).BeginInit();
            SuspendLayout();
            // 
            // tbcProdut
            // 
            tbcProdut.Controls.Add(tbProduct);
            tbcProdut.Controls.Add(tbUnshelve);
            tbcProdut.Controls.Add(tbOrderMan);
            tbcProdut.Controls.Add(tbSale);
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
            // tbUnshelve
            // 
            tbUnshelve.Controls.Add(lbUnPage);
            tbUnshelve.Controls.Add(cbUnPage);
            tbUnshelve.Controls.Add(btnUnBackPage);
            tbUnshelve.Controls.Add(btnUnNextPage);
            tbUnshelve.Controls.Add(productCard9);
            tbUnshelve.Controls.Add(productCard10);
            tbUnshelve.Controls.Add(productCard11);
            tbUnshelve.Controls.Add(productCard12);
            tbUnshelve.Controls.Add(productCard13);
            tbUnshelve.Controls.Add(productCard14);
            tbUnshelve.Controls.Add(productCard15);
            tbUnshelve.Controls.Add(productCard16);
            tbUnshelve.Location = new Point(4, 24);
            tbUnshelve.Name = "tbUnshelve";
            tbUnshelve.Padding = new Padding(3);
            tbUnshelve.Size = new Size(1076, 754);
            tbUnshelve.TabIndex = 1;
            tbUnshelve.Tag = "2";
            tbUnshelve.Text = "下架商品";
            tbUnshelve.UseVisualStyleBackColor = true;
            // 
            // lbUnPage
            // 
            lbUnPage.AutoSize = true;
            lbUnPage.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbUnPage.Location = new Point(898, 707);
            lbUnPage.Name = "lbUnPage";
            lbUnPage.Size = new Size(42, 17);
            lbUnPage.TabIndex = 34;
            lbUnPage.Text = "/10頁";
            // 
            // cbUnPage
            // 
            cbUnPage.BackColor = SystemColors.Window;
            cbUnPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnPage.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbUnPage.FormattingEnabled = true;
            cbUnPage.Location = new Point(842, 692);
            cbUnPage.Name = "cbUnPage";
            cbUnPage.Size = new Size(50, 32);
            cbUnPage.TabIndex = 33;
            cbUnPage.SelectedIndexChanged += cbUnPage_SelectedIndexChanged;
            // 
            // btnUnBackPage
            // 
            btnUnBackPage.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnUnBackPage.Location = new Point(730, 687);
            btnUnBackPage.Name = "btnUnBackPage";
            btnUnBackPage.Size = new Size(96, 43);
            btnUnBackPage.TabIndex = 32;
            btnUnBackPage.Text = "上一頁";
            btnUnBackPage.UseVisualStyleBackColor = true;
            btnUnBackPage.Click += btnUnBackPage_Click;
            // 
            // btnUnNextPage
            // 
            btnUnNextPage.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnUnNextPage.Location = new Point(954, 687);
            btnUnNextPage.Name = "btnUnNextPage";
            btnUnNextPage.Size = new Size(96, 43);
            btnUnNextPage.TabIndex = 31;
            btnUnNextPage.Text = "下一頁";
            btnUnNextPage.UseVisualStyleBackColor = true;
            btnUnNextPage.Click += btnUnNextPage_Click;
            // 
            // productCard9
            // 
            productCard9.BorderStyle = BorderStyle.FixedSingle;
            productCard9.Location = new Point(26, 23);
            productCard9.Name = "productCard9";
            productCard9.Size = new Size(230, 304);
            productCard9.TabIndex = 23;
            productCard9.Visible = false;
            // 
            // productCard10
            // 
            productCard10.BorderStyle = BorderStyle.FixedSingle;
            productCard10.Location = new Point(297, 23);
            productCard10.Name = "productCard10";
            productCard10.Size = new Size(230, 304);
            productCard10.TabIndex = 22;
            productCard10.Visible = false;
            // 
            // productCard11
            // 
            productCard11.BorderStyle = BorderStyle.FixedSingle;
            productCard11.Location = new Point(558, 23);
            productCard11.Name = "productCard11";
            productCard11.Size = new Size(230, 304);
            productCard11.TabIndex = 21;
            productCard11.Visible = false;
            // 
            // productCard12
            // 
            productCard12.BorderStyle = BorderStyle.FixedSingle;
            productCard12.Location = new Point(818, 23);
            productCard12.Name = "productCard12";
            productCard12.Size = new Size(230, 304);
            productCard12.TabIndex = 20;
            productCard12.Visible = false;
            // 
            // productCard13
            // 
            productCard13.BorderStyle = BorderStyle.FixedSingle;
            productCard13.Location = new Point(26, 358);
            productCard13.Name = "productCard13";
            productCard13.Size = new Size(230, 304);
            productCard13.TabIndex = 19;
            productCard13.Visible = false;
            // 
            // productCard14
            // 
            productCard14.BorderStyle = BorderStyle.FixedSingle;
            productCard14.Location = new Point(297, 358);
            productCard14.Name = "productCard14";
            productCard14.Size = new Size(230, 304);
            productCard14.TabIndex = 18;
            productCard14.Visible = false;
            // 
            // productCard15
            // 
            productCard15.BorderStyle = BorderStyle.FixedSingle;
            productCard15.Location = new Point(558, 358);
            productCard15.Name = "productCard15";
            productCard15.Size = new Size(230, 304);
            productCard15.TabIndex = 17;
            productCard15.Visible = false;
            // 
            // productCard16
            // 
            productCard16.BorderStyle = BorderStyle.FixedSingle;
            productCard16.Location = new Point(818, 358);
            productCard16.Name = "productCard16";
            productCard16.Size = new Size(230, 304);
            productCard16.TabIndex = 16;
            productCard16.Visible = false;
            // 
            // tbOrderMan
            // 
            tbOrderMan.Controls.Add(ptbMOdr_Confirmed);
            tbOrderMan.Controls.Add(lbMOdr_Confirmed);
            tbOrderMan.Controls.Add(ptbMOdr_IsCancel);
            tbOrderMan.Controls.Add(ptbMOdr_unConfirmed);
            tbOrderMan.Controls.Add(ptbMOdr_isRead);
            tbOrderMan.Controls.Add(lbMOdr_unConfirmed);
            tbOrderMan.Controls.Add(lbMOdr_IsCancel);
            tbOrderMan.Controls.Add(gbOdrSearch);
            tbOrderMan.Controls.Add(btnMOdrCancel);
            tbOrderMan.Controls.Add(cbMOdr_Number);
            tbOrderMan.Controls.Add(lbMOdr_IsRead);
            tbOrderMan.Controls.Add(lbMOdr_Number);
            tbOrderMan.Controls.Add(btnMOdrMessage);
            tbOrderMan.Controls.Add(lbMOdr);
            tbOrderMan.Controls.Add(btnMOdrConfirmed);
            tbOrderMan.Controls.Add(flpMOdr);
            tbOrderMan.Controls.Add(ptbMOdr);
            tbOrderMan.Controls.Add(lbMOdr_Date);
            tbOrderMan.Controls.Add(txbMOdr_Total);
            tbOrderMan.Controls.Add(txbMOdr_OAddress);
            tbOrderMan.Controls.Add(lbMOdr_RName);
            tbOrderMan.Controls.Add(lbMOdr_Payment);
            tbOrderMan.Controls.Add(lbMOdr_OName);
            tbOrderMan.Controls.Add(lbMOdr_OAddress);
            tbOrderMan.Controls.Add(lbMOdr_RAddress);
            tbOrderMan.Controls.Add(txbMOdr_RAddress);
            tbOrderMan.Location = new Point(4, 24);
            tbOrderMan.Name = "tbOrderMan";
            tbOrderMan.Padding = new Padding(3);
            tbOrderMan.Size = new Size(1076, 754);
            tbOrderMan.TabIndex = 2;
            tbOrderMan.Text = "訂單管理";
            tbOrderMan.UseVisualStyleBackColor = true;
            // 
            // ptbMOdr_Confirmed
            // 
            ptbMOdr_Confirmed.Image = Properties.Resources.truck;
            ptbMOdr_Confirmed.Location = new Point(353, 280);
            ptbMOdr_Confirmed.Name = "ptbMOdr_Confirmed";
            ptbMOdr_Confirmed.Size = new Size(64, 65);
            ptbMOdr_Confirmed.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMOdr_Confirmed.TabIndex = 69;
            ptbMOdr_Confirmed.TabStop = false;
            ptbMOdr_Confirmed.Visible = false;
            // 
            // lbMOdr_Confirmed
            // 
            lbMOdr_Confirmed.AutoSize = true;
            lbMOdr_Confirmed.BackColor = Color.MistyRose;
            lbMOdr_Confirmed.BorderStyle = BorderStyle.FixedSingle;
            lbMOdr_Confirmed.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_Confirmed.Location = new Point(328, 348);
            lbMOdr_Confirmed.Name = "lbMOdr_Confirmed";
            lbMOdr_Confirmed.Size = new Size(107, 26);
            lbMOdr_Confirmed.TabIndex = 68;
            lbMOdr_Confirmed.Text = "訂單已確認";
            lbMOdr_Confirmed.Visible = false;
            // 
            // ptbMOdr_IsCancel
            // 
            ptbMOdr_IsCancel.Image = Properties.Resources.cancel;
            ptbMOdr_IsCancel.Location = new Point(493, 280);
            ptbMOdr_IsCancel.Name = "ptbMOdr_IsCancel";
            ptbMOdr_IsCancel.Size = new Size(64, 65);
            ptbMOdr_IsCancel.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMOdr_IsCancel.TabIndex = 67;
            ptbMOdr_IsCancel.TabStop = false;
            ptbMOdr_IsCancel.Visible = false;
            // 
            // ptbMOdr_unConfirmed
            // 
            ptbMOdr_unConfirmed.Image = Properties.Resources.order_fulfillment;
            ptbMOdr_unConfirmed.Location = new Point(216, 280);
            ptbMOdr_unConfirmed.Name = "ptbMOdr_unConfirmed";
            ptbMOdr_unConfirmed.Size = new Size(64, 65);
            ptbMOdr_unConfirmed.TabIndex = 66;
            ptbMOdr_unConfirmed.TabStop = false;
            ptbMOdr_unConfirmed.Visible = false;
            // 
            // ptbMOdr_isRead
            // 
            ptbMOdr_isRead.Image = Properties.Resources.message;
            ptbMOdr_isRead.Location = new Point(72, 280);
            ptbMOdr_isRead.Name = "ptbMOdr_isRead";
            ptbMOdr_isRead.Size = new Size(64, 65);
            ptbMOdr_isRead.TabIndex = 65;
            ptbMOdr_isRead.TabStop = false;
            ptbMOdr_isRead.Visible = false;
            // 
            // lbMOdr_unConfirmed
            // 
            lbMOdr_unConfirmed.AutoSize = true;
            lbMOdr_unConfirmed.BackColor = Color.MistyRose;
            lbMOdr_unConfirmed.BorderStyle = BorderStyle.FixedSingle;
            lbMOdr_unConfirmed.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_unConfirmed.Location = new Point(190, 348);
            lbMOdr_unConfirmed.Name = "lbMOdr_unConfirmed";
            lbMOdr_unConfirmed.Size = new Size(107, 26);
            lbMOdr_unConfirmed.TabIndex = 64;
            lbMOdr_unConfirmed.Text = "訂單未確認";
            lbMOdr_unConfirmed.Visible = false;
            // 
            // lbMOdr_IsCancel
            // 
            lbMOdr_IsCancel.AutoSize = true;
            lbMOdr_IsCancel.BackColor = Color.MistyRose;
            lbMOdr_IsCancel.BorderStyle = BorderStyle.FixedSingle;
            lbMOdr_IsCancel.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_IsCancel.Location = new Point(468, 348);
            lbMOdr_IsCancel.Name = "lbMOdr_IsCancel";
            lbMOdr_IsCancel.Size = new Size(107, 26);
            lbMOdr_IsCancel.TabIndex = 63;
            lbMOdr_IsCancel.Text = "訂單已刪除";
            lbMOdr_IsCancel.Visible = false;
            // 
            // gbOdrSearch
            // 
            gbOdrSearch.Controls.Add(cbOdrSIsRead);
            gbOdrSearch.Controls.Add(lbOdrSIsRead);
            gbOdrSearch.Controls.Add(btnOdrYear);
            gbOdrSearch.Controls.Add(btnOdrMonth);
            gbOdrSearch.Controls.Add(btnOdrWeek);
            gbOdrSearch.Controls.Add(btnOdrToday);
            gbOdrSearch.Controls.Add(rbtnOdrSName);
            gbOdrSearch.Controls.Add(rbtnOdrSId);
            gbOdrSearch.Controls.Add(ptbOdrSearch);
            gbOdrSearch.Controls.Add(cbOdrSIsConfirmed);
            gbOdrSearch.Controls.Add(lbOdrSIsConfirmed);
            gbOdrSearch.Controls.Add(cbOdrSIsCancel);
            gbOdrSearch.Controls.Add(lbOdrSIsCancel);
            gbOdrSearch.Controls.Add(cbOdrSPayMent);
            gbOdrSearch.Controls.Add(lbOdrSPayMent);
            gbOdrSearch.Controls.Add(cbOdrSProduct);
            gbOdrSearch.Controls.Add(lbOdrSProduct);
            gbOdrSearch.Controls.Add(txbOdrSName);
            gbOdrSearch.Controls.Add(lbOdrSName);
            gbOdrSearch.Controls.Add(dtpOdrTime2);
            gbOdrSearch.Controls.Add(lbTime2);
            gbOdrSearch.Controls.Add(lbTime);
            gbOdrSearch.Controls.Add(btnOdrClear);
            gbOdrSearch.Controls.Add(btnOdrSearch);
            gbOdrSearch.Controls.Add(dtpOdrTime);
            gbOdrSearch.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gbOdrSearch.Location = new Point(20, 377);
            gbOdrSearch.Name = "gbOdrSearch";
            gbOdrSearch.Size = new Size(592, 357);
            gbOdrSearch.TabIndex = 62;
            gbOdrSearch.TabStop = false;
            gbOdrSearch.Text = "訂單查詢";
            // 
            // cbOdrSIsRead
            // 
            cbOdrSIsRead.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOdrSIsRead.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbOdrSIsRead.FormattingEnabled = true;
            cbOdrSIsRead.Items.AddRange(new object[] { "", "已讀", "未讀" });
            cbOdrSIsRead.Location = new Point(319, 263);
            cbOdrSIsRead.Name = "cbOdrSIsRead";
            cbOdrSIsRead.Size = new Size(74, 28);
            cbOdrSIsRead.TabIndex = 75;
            // 
            // lbOdrSIsRead
            // 
            lbOdrSIsRead.AutoEllipsis = true;
            lbOdrSIsRead.AutoSize = true;
            lbOdrSIsRead.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdrSIsRead.Location = new Point(205, 267);
            lbOdrSIsRead.Name = "lbOdrSIsRead";
            lbOdrSIsRead.Size = new Size(109, 24);
            lbOdrSIsRead.TabIndex = 74;
            lbOdrSIsRead.Text = "是否有訊息:";
            // 
            // btnOdrYear
            // 
            btnOdrYear.Font = new Font("Microsoft JhengHei UI", 11.25F);
            btnOdrYear.Location = new Point(349, 79);
            btnOdrYear.Name = "btnOdrYear";
            btnOdrYear.Size = new Size(63, 27);
            btnOdrYear.TabIndex = 73;
            btnOdrYear.Text = "今年";
            btnOdrYear.UseVisualStyleBackColor = true;
            btnOdrYear.Click += btnOdrYear_Click;
            // 
            // btnOdrMonth
            // 
            btnOdrMonth.Font = new Font("Microsoft JhengHei UI", 11.25F);
            btnOdrMonth.Location = new Point(280, 79);
            btnOdrMonth.Name = "btnOdrMonth";
            btnOdrMonth.Size = new Size(63, 27);
            btnOdrMonth.TabIndex = 72;
            btnOdrMonth.Text = "本月";
            btnOdrMonth.UseVisualStyleBackColor = true;
            btnOdrMonth.Click += btnOdrMonth_Click;
            // 
            // btnOdrWeek
            // 
            btnOdrWeek.Font = new Font("Microsoft JhengHei UI", 11.25F);
            btnOdrWeek.Location = new Point(349, 46);
            btnOdrWeek.Name = "btnOdrWeek";
            btnOdrWeek.Size = new Size(63, 27);
            btnOdrWeek.TabIndex = 71;
            btnOdrWeek.Text = "本周";
            btnOdrWeek.UseVisualStyleBackColor = true;
            btnOdrWeek.Click += btnOdrWeek_Click;
            // 
            // btnOdrToday
            // 
            btnOdrToday.Font = new Font("Microsoft JhengHei UI", 11.25F);
            btnOdrToday.Location = new Point(280, 46);
            btnOdrToday.Name = "btnOdrToday";
            btnOdrToday.Size = new Size(63, 27);
            btnOdrToday.TabIndex = 70;
            btnOdrToday.Text = "今天";
            btnOdrToday.UseVisualStyleBackColor = true;
            btnOdrToday.Click += btnOdrToday_Click;
            // 
            // rbtnOdrSName
            // 
            rbtnOdrSName.AutoSize = true;
            rbtnOdrSName.Location = new Point(319, 130);
            rbtnOdrSName.Name = "rbtnOdrSName";
            rbtnOdrSName.Size = new Size(66, 28);
            rbtnOdrSName.TabIndex = 69;
            rbtnOdrSName.Text = "名稱";
            rbtnOdrSName.UseVisualStyleBackColor = true;
            // 
            // rbtnOdrSId
            // 
            rbtnOdrSId.AutoSize = true;
            rbtnOdrSId.Checked = true;
            rbtnOdrSId.Location = new Point(266, 130);
            rbtnOdrSId.Name = "rbtnOdrSId";
            rbtnOdrSId.Size = new Size(47, 28);
            rbtnOdrSId.TabIndex = 68;
            rbtnOdrSId.TabStop = true;
            rbtnOdrSId.Text = "ID";
            rbtnOdrSId.UseVisualStyleBackColor = true;
            rbtnOdrSId.CheckedChanged += rbtnOdrS_CheckedChanged;
            // 
            // ptbOdrSearch
            // 
            ptbOdrSearch.Image = Properties.Resources.searching;
            ptbOdrSearch.Location = new Point(455, 21);
            ptbOdrSearch.Name = "ptbOdrSearch";
            ptbOdrSearch.Size = new Size(131, 143);
            ptbOdrSearch.TabIndex = 63;
            ptbOdrSearch.TabStop = false;
            // 
            // cbOdrSIsConfirmed
            // 
            cbOdrSIsConfirmed.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOdrSIsConfirmed.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbOdrSIsConfirmed.FormattingEnabled = true;
            cbOdrSIsConfirmed.Items.AddRange(new object[] { "", "已確認", "未確認" });
            cbOdrSIsConfirmed.Location = new Point(110, 305);
            cbOdrSIsConfirmed.Name = "cbOdrSIsConfirmed";
            cbOdrSIsConfirmed.Size = new Size(74, 28);
            cbOdrSIsConfirmed.TabIndex = 67;
            // 
            // lbOdrSIsConfirmed
            // 
            lbOdrSIsConfirmed.AutoEllipsis = true;
            lbOdrSIsConfirmed.AutoSize = true;
            lbOdrSIsConfirmed.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdrSIsConfirmed.Location = new Point(17, 309);
            lbOdrSIsConfirmed.Name = "lbOdrSIsConfirmed";
            lbOdrSIsConfirmed.Size = new Size(90, 24);
            lbOdrSIsConfirmed.TabIndex = 66;
            lbOdrSIsConfirmed.Text = "是否確認:";
            // 
            // cbOdrSIsCancel
            // 
            cbOdrSIsCancel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOdrSIsCancel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbOdrSIsCancel.FormattingEnabled = true;
            cbOdrSIsCancel.Items.AddRange(new object[] { "", "已取消", "未取消" });
            cbOdrSIsCancel.Location = new Point(110, 263);
            cbOdrSIsCancel.Name = "cbOdrSIsCancel";
            cbOdrSIsCancel.Size = new Size(74, 28);
            cbOdrSIsCancel.TabIndex = 65;
            // 
            // lbOdrSIsCancel
            // 
            lbOdrSIsCancel.AutoEllipsis = true;
            lbOdrSIsCancel.AutoSize = true;
            lbOdrSIsCancel.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdrSIsCancel.Location = new Point(17, 267);
            lbOdrSIsCancel.Name = "lbOdrSIsCancel";
            lbOdrSIsCancel.Size = new Size(90, 24);
            lbOdrSIsCancel.TabIndex = 64;
            lbOdrSIsCancel.Text = "是否取消:";
            // 
            // cbOdrSPayMent
            // 
            cbOdrSPayMent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOdrSPayMent.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbOdrSPayMent.FormattingEnabled = true;
            cbOdrSPayMent.Location = new Point(110, 220);
            cbOdrSPayMent.Name = "cbOdrSPayMent";
            cbOdrSPayMent.Size = new Size(185, 28);
            cbOdrSPayMent.TabIndex = 63;
            // 
            // lbOdrSPayMent
            // 
            lbOdrSPayMent.AutoEllipsis = true;
            lbOdrSPayMent.AutoSize = true;
            lbOdrSPayMent.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdrSPayMent.Location = new Point(17, 224);
            lbOdrSPayMent.Name = "lbOdrSPayMent";
            lbOdrSPayMent.Size = new Size(90, 24);
            lbOdrSPayMent.TabIndex = 62;
            lbOdrSPayMent.Text = "付款方式:";
            // 
            // cbOdrSProduct
            // 
            cbOdrSProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOdrSProduct.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbOdrSProduct.FormattingEnabled = true;
            cbOdrSProduct.Location = new Point(110, 173);
            cbOdrSProduct.Name = "cbOdrSProduct";
            cbOdrSProduct.Size = new Size(185, 28);
            cbOdrSProduct.TabIndex = 61;
            // 
            // lbOdrSProduct
            // 
            lbOdrSProduct.AutoEllipsis = true;
            lbOdrSProduct.AutoSize = true;
            lbOdrSProduct.Font = new Font("微軟正黑體", 14.25F);
            lbOdrSProduct.Location = new Point(17, 177);
            lbOdrSProduct.Name = "lbOdrSProduct";
            lbOdrSProduct.Size = new Size(90, 24);
            lbOdrSProduct.TabIndex = 60;
            lbOdrSProduct.Text = "包含產品:";
            // 
            // txbOdrSName
            // 
            txbOdrSName.BackColor = SystemColors.Window;
            txbOdrSName.Location = new Point(75, 122);
            txbOdrSName.MaxLength = 30;
            txbOdrSName.Name = "txbOdrSName";
            txbOdrSName.Size = new Size(185, 32);
            txbOdrSName.TabIndex = 59;
            txbOdrSName.KeyPress += checkNum_KeyPress;
            // 
            // lbOdrSName
            // 
            lbOdrSName.AutoEllipsis = true;
            lbOdrSName.AutoSize = true;
            lbOdrSName.Font = new Font("微軟正黑體", 14.25F);
            lbOdrSName.Location = new Point(17, 130);
            lbOdrSName.Name = "lbOdrSName";
            lbOdrSName.Size = new Size(52, 24);
            lbOdrSName.TabIndex = 57;
            lbOdrSName.Text = "會員:";
            // 
            // dtpOdrTime2
            // 
            dtpOdrTime2.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dtpOdrTime2.Location = new Point(75, 77);
            dtpOdrTime2.Name = "dtpOdrTime2";
            dtpOdrTime2.Size = new Size(185, 27);
            dtpOdrTime2.TabIndex = 56;
            dtpOdrTime2.Value = new DateTime(2024, 5, 19, 0, 0, 0, 0);
            // 
            // lbTime2
            // 
            lbTime2.AutoEllipsis = true;
            lbTime2.AutoSize = true;
            lbTime2.Font = new Font("微軟正黑體", 14.25F);
            lbTime2.Location = new Point(42, 79);
            lbTime2.Name = "lbTime2";
            lbTime2.Size = new Size(29, 24);
            lbTime2.TabIndex = 55;
            lbTime2.Text = "至";
            // 
            // lbTime
            // 
            lbTime.AutoEllipsis = true;
            lbTime.AutoSize = true;
            lbTime.Font = new Font("微軟正黑體", 14.25F);
            lbTime.Location = new Point(17, 46);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(52, 24);
            lbTime.TabIndex = 54;
            lbTime.Text = "時間:";
            // 
            // btnOdrClear
            // 
            btnOdrClear.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnOdrClear.Location = new Point(388, 308);
            btnOdrClear.Name = "btnOdrClear";
            btnOdrClear.Size = new Size(96, 43);
            btnOdrClear.TabIndex = 32;
            btnOdrClear.Text = "清除條件";
            btnOdrClear.UseVisualStyleBackColor = true;
            btnOdrClear.Click += btnOdrClear_Click;
            // 
            // btnOdrSearch
            // 
            btnOdrSearch.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnOdrSearch.Location = new Point(490, 308);
            btnOdrSearch.Name = "btnOdrSearch";
            btnOdrSearch.Size = new Size(96, 43);
            btnOdrSearch.TabIndex = 31;
            btnOdrSearch.Text = "搜尋";
            btnOdrSearch.UseVisualStyleBackColor = true;
            btnOdrSearch.Click += btnOdrSearch_Click;
            // 
            // dtpOdrTime
            // 
            dtpOdrTime.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dtpOdrTime.Location = new Point(75, 44);
            dtpOdrTime.Name = "dtpOdrTime";
            dtpOdrTime.Size = new Size(185, 27);
            dtpOdrTime.TabIndex = 0;
            dtpOdrTime.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // btnMOdrCancel
            // 
            btnMOdrCancel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnMOdrCancel.Location = new Point(864, 707);
            btnMOdrCancel.Name = "btnMOdrCancel";
            btnMOdrCancel.Size = new Size(96, 43);
            btnMOdrCancel.TabIndex = 61;
            btnMOdrCancel.Text = "取消訂單";
            btnMOdrCancel.UseVisualStyleBackColor = true;
            btnMOdrCancel.Click += btnCancelOrder_Click;
            // 
            // cbMOdr_Number
            // 
            cbMOdr_Number.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMOdr_Number.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbMOdr_Number.FormattingEnabled = true;
            cbMOdr_Number.Location = new Point(112, 87);
            cbMOdr_Number.Name = "cbMOdr_Number";
            cbMOdr_Number.Size = new Size(159, 28);
            cbMOdr_Number.TabIndex = 44;
            cbMOdr_Number.SelectedIndexChanged += cbMOdr_Number_SelectedIndexChanged;
            // 
            // lbMOdr_IsRead
            // 
            lbMOdr_IsRead.AutoSize = true;
            lbMOdr_IsRead.BackColor = Color.MistyRose;
            lbMOdr_IsRead.BorderStyle = BorderStyle.FixedSingle;
            lbMOdr_IsRead.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_IsRead.Location = new Point(30, 348);
            lbMOdr_IsRead.Name = "lbMOdr_IsRead";
            lbMOdr_IsRead.Size = new Size(145, 26);
            lbMOdr_IsRead.TabIndex = 60;
            lbMOdr_IsRead.Text = "使用者未讀訊息";
            lbMOdr_IsRead.Visible = false;
            // 
            // lbMOdr_Number
            // 
            lbMOdr_Number.AutoEllipsis = true;
            lbMOdr_Number.AutoSize = true;
            lbMOdr_Number.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_Number.Location = new Point(20, 87);
            lbMOdr_Number.Name = "lbMOdr_Number";
            lbMOdr_Number.Size = new Size(86, 24);
            lbMOdr_Number.TabIndex = 45;
            lbMOdr_Number.Text = "訂單編號";
            // 
            // btnMOdrMessage
            // 
            btnMOdrMessage.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnMOdrMessage.Location = new Point(762, 707);
            btnMOdrMessage.Name = "btnMOdrMessage";
            btnMOdrMessage.Size = new Size(96, 43);
            btnMOdrMessage.TabIndex = 59;
            btnMOdrMessage.Text = "傳送訊息";
            btnMOdrMessage.UseVisualStyleBackColor = true;
            btnMOdrMessage.Click += btnMessage_Click;
            // 
            // lbMOdr
            // 
            lbMOdr.AutoSize = true;
            lbMOdr.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbMOdr.Location = new Point(20, 23);
            lbMOdr.Name = "lbMOdr";
            lbMOdr.Size = new Size(146, 41);
            lbMOdr.TabIndex = 46;
            lbMOdr.Text = "訂單確認";
            // 
            // btnMOdrConfirmed
            // 
            btnMOdrConfirmed.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnMOdrConfirmed.Location = new Point(965, 707);
            btnMOdrConfirmed.Name = "btnMOdrConfirmed";
            btnMOdrConfirmed.Size = new Size(96, 43);
            btnMOdrConfirmed.TabIndex = 58;
            btnMOdrConfirmed.Text = "確認訂單";
            btnMOdrConfirmed.UseVisualStyleBackColor = true;
            btnMOdrConfirmed.Click += btnConfirmed_Click;
            // 
            // flpMOdr
            // 
            flpMOdr.AutoScroll = true;
            flpMOdr.BackgroundImage = Properties.Resources.shopping_cart2;
            flpMOdr.BackgroundImageLayout = ImageLayout.Center;
            flpMOdr.BorderStyle = BorderStyle.FixedSingle;
            flpMOdr.Location = new Point(630, 157);
            flpMOdr.Name = "flpMOdr";
            flpMOdr.Size = new Size(431, 496);
            flpMOdr.TabIndex = 47;
            flpMOdr.ControlAdded += flp_ControlChange;
            // 
            // ptbMOdr
            // 
            ptbMOdr.Image = Properties.Resources.clipboard;
            ptbMOdr.Location = new Point(930, 5);
            ptbMOdr.Name = "ptbMOdr";
            ptbMOdr.Size = new Size(131, 143);
            ptbMOdr.TabIndex = 57;
            ptbMOdr.TabStop = false;
            // 
            // lbMOdr_Date
            // 
            lbMOdr_Date.AutoEllipsis = true;
            lbMOdr_Date.AutoSize = true;
            lbMOdr_Date.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_Date.Location = new Point(286, 91);
            lbMOdr_Date.Name = "lbMOdr_Date";
            lbMOdr_Date.Size = new Size(95, 24);
            lbMOdr_Date.TabIndex = 48;
            lbMOdr_Date.Text = "訂購日期 :";
            // 
            // txbMOdr_Total
            // 
            txbMOdr_Total.BackColor = SystemColors.Window;
            txbMOdr_Total.BorderStyle = BorderStyle.None;
            txbMOdr_Total.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbMOdr_Total.Location = new Point(802, 660);
            txbMOdr_Total.Name = "txbMOdr_Total";
            txbMOdr_Total.ReadOnly = true;
            txbMOdr_Total.Size = new Size(259, 41);
            txbMOdr_Total.TabIndex = 56;
            txbMOdr_Total.TextAlign = HorizontalAlignment.Right;
            // 
            // txbMOdr_OAddress
            // 
            txbMOdr_OAddress.BackColor = SystemColors.Window;
            txbMOdr_OAddress.BorderStyle = BorderStyle.None;
            txbMOdr_OAddress.Font = new Font("微軟正黑體", 14.25F);
            txbMOdr_OAddress.Location = new Point(140, 163);
            txbMOdr_OAddress.Name = "txbMOdr_OAddress";
            txbMOdr_OAddress.ReadOnly = true;
            txbMOdr_OAddress.RightToLeft = RightToLeft.Yes;
            txbMOdr_OAddress.Size = new Size(407, 26);
            txbMOdr_OAddress.TabIndex = 49;
            txbMOdr_OAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // lbMOdr_RName
            // 
            lbMOdr_RName.AutoEllipsis = true;
            lbMOdr_RName.AutoSize = true;
            lbMOdr_RName.Font = new Font("微軟正黑體", 14.25F);
            lbMOdr_RName.Location = new Point(20, 207);
            lbMOdr_RName.Name = "lbMOdr_RName";
            lbMOdr_RName.Size = new Size(114, 24);
            lbMOdr_RName.TabIndex = 55;
            lbMOdr_RName.Text = "收貨人姓名 :";
            // 
            // lbMOdr_Payment
            // 
            lbMOdr_Payment.AutoEllipsis = true;
            lbMOdr_Payment.AutoSize = true;
            lbMOdr_Payment.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_Payment.Location = new Point(562, 91);
            lbMOdr_Payment.Name = "lbMOdr_Payment";
            lbMOdr_Payment.Size = new Size(95, 24);
            lbMOdr_Payment.TabIndex = 50;
            lbMOdr_Payment.Text = "付款方式 :";
            // 
            // lbMOdr_OName
            // 
            lbMOdr_OName.AutoEllipsis = true;
            lbMOdr_OName.AutoSize = true;
            lbMOdr_OName.Font = new Font("微軟正黑體", 14.25F);
            lbMOdr_OName.Location = new Point(20, 125);
            lbMOdr_OName.Name = "lbMOdr_OName";
            lbMOdr_OName.Size = new Size(114, 24);
            lbMOdr_OName.TabIndex = 54;
            lbMOdr_OName.Text = "訂購人姓名 :";
            // 
            // lbMOdr_OAddress
            // 
            lbMOdr_OAddress.AutoEllipsis = true;
            lbMOdr_OAddress.AutoSize = true;
            lbMOdr_OAddress.Font = new Font("微軟正黑體", 14.25F);
            lbMOdr_OAddress.Location = new Point(20, 163);
            lbMOdr_OAddress.Name = "lbMOdr_OAddress";
            lbMOdr_OAddress.Size = new Size(114, 24);
            lbMOdr_OAddress.TabIndex = 51;
            lbMOdr_OAddress.Text = "訂購人地址 :";
            // 
            // lbMOdr_RAddress
            // 
            lbMOdr_RAddress.AutoEllipsis = true;
            lbMOdr_RAddress.AutoSize = true;
            lbMOdr_RAddress.Font = new Font("微軟正黑體", 14.25F);
            lbMOdr_RAddress.Location = new Point(20, 250);
            lbMOdr_RAddress.Name = "lbMOdr_RAddress";
            lbMOdr_RAddress.Size = new Size(114, 24);
            lbMOdr_RAddress.TabIndex = 53;
            lbMOdr_RAddress.Text = "收貨人地址 :";
            // 
            // txbMOdr_RAddress
            // 
            txbMOdr_RAddress.BackColor = SystemColors.Window;
            txbMOdr_RAddress.BorderStyle = BorderStyle.None;
            txbMOdr_RAddress.Font = new Font("微軟正黑體", 14.25F);
            txbMOdr_RAddress.Location = new Point(140, 248);
            txbMOdr_RAddress.Name = "txbMOdr_RAddress";
            txbMOdr_RAddress.ReadOnly = true;
            txbMOdr_RAddress.RightToLeft = RightToLeft.Yes;
            txbMOdr_RAddress.Size = new Size(407, 26);
            txbMOdr_RAddress.TabIndex = 52;
            txbMOdr_RAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // tbSale
            // 
            tbSale.Controls.Add(btn_test);
            tbSale.Controls.Add(ptvSL);
            tbSale.Controls.Add(lbSale);
            tbSale.Controls.Add(gbSale);
            tbSale.Location = new Point(4, 24);
            tbSale.Name = "tbSale";
            tbSale.Padding = new Padding(3);
            tbSale.Size = new Size(1076, 754);
            tbSale.TabIndex = 3;
            tbSale.Text = "銷售狀態";
            tbSale.UseVisualStyleBackColor = true;
            // 
            // btn_test
            // 
            btn_test.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_test.Location = new Point(670, 34);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(96, 43);
            btn_test.TabIndex = 32;
            btn_test.Text = "搜尋";
            btn_test.UseVisualStyleBackColor = true;
            btn_test.Click += btn_test_Click;
            // 
            // ptvSL
            // 
            ptvSL.Location = new Point(20, 337);
            ptvSL.Name = "ptvSL";
            ptvSL.PanCursor = Cursors.Hand;
            ptvSL.Size = new Size(1050, 386);
            ptvSL.TabIndex = 65;
            ptvSL.Text = "plotView1";
            ptvSL.ZoomHorizontalCursor = Cursors.SizeWE;
            ptvSL.ZoomRectangleCursor = Cursors.SizeNWSE;
            ptvSL.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // lbSale
            // 
            lbSale.AutoSize = true;
            lbSale.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbSale.Location = new Point(20, 23);
            lbSale.Name = "lbSale";
            lbSale.Size = new Size(146, 41);
            lbSale.TabIndex = 64;
            lbSale.Text = "銷售狀態";
            // 
            // gbSale
            // 
            gbSale.Controls.Add(ptbSale);
            gbSale.Controls.Add(gbSaleY);
            gbSale.Controls.Add(gbSaleX);
            gbSale.Controls.Add(btnSLClear);
            gbSale.Controls.Add(btnSLSearch);
            gbSale.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gbSale.Location = new Point(20, 83);
            gbSale.Name = "gbSale";
            gbSale.Size = new Size(1050, 248);
            gbSale.TabIndex = 63;
            gbSale.TabStop = false;
            gbSale.Text = "銷售查詢";
            // 
            // ptbSale
            // 
            ptbSale.Image = Properties.Resources.shopping_online;
            ptbSale.Location = new Point(846, 31);
            ptbSale.Name = "ptbSale";
            ptbSale.Size = new Size(204, 162);
            ptbSale.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbSale.TabIndex = 76;
            ptbSale.TabStop = false;
            // 
            // gbSaleY
            // 
            gbSaleY.Controls.Add(rbtnSLOrderCount);
            gbSaleY.Controls.Add(rbtnSLTatal);
            gbSaleY.Controls.Add(rbtnSLQuantity);
            gbSaleY.Location = new Point(625, 31);
            gbSaleY.Name = "gbSaleY";
            gbSaleY.Size = new Size(215, 211);
            gbSaleY.TabIndex = 75;
            gbSaleY.TabStop = false;
            gbSaleY.Text = "Y軸";
            // 
            // rbtnSLOrderCount
            // 
            rbtnSLOrderCount.AutoSize = true;
            rbtnSLOrderCount.Location = new Point(25, 109);
            rbtnSLOrderCount.Name = "rbtnSLOrderCount";
            rbtnSLOrderCount.Size = new Size(104, 28);
            rbtnSLOrderCount.TabIndex = 91;
            rbtnSLOrderCount.TabStop = true;
            rbtnSLOrderCount.Text = "訂單數量";
            rbtnSLOrderCount.UseVisualStyleBackColor = true;
            // 
            // rbtnSLTatal
            // 
            rbtnSLTatal.AutoSize = true;
            rbtnSLTatal.Location = new Point(25, 75);
            rbtnSLTatal.Name = "rbtnSLTatal";
            rbtnSLTatal.Size = new Size(85, 28);
            rbtnSLTatal.TabIndex = 90;
            rbtnSLTatal.TabStop = true;
            rbtnSLTatal.Text = "銷售額";
            rbtnSLTatal.UseVisualStyleBackColor = true;
            // 
            // rbtnSLQuantity
            // 
            rbtnSLQuantity.AutoSize = true;
            rbtnSLQuantity.Location = new Point(25, 41);
            rbtnSLQuantity.Name = "rbtnSLQuantity";
            rbtnSLQuantity.Size = new Size(66, 28);
            rbtnSLQuantity.TabIndex = 89;
            rbtnSLQuantity.TabStop = true;
            rbtnSLQuantity.Text = "數量";
            rbtnSLQuantity.UseVisualStyleBackColor = true;
            // 
            // gbSaleX
            // 
            gbSaleX.Controls.Add(radioButton1);
            gbSaleX.Controls.Add(radioButton2);
            gbSaleX.Controls.Add(txbSLMember);
            gbSaleX.Controls.Add(ckbSLTime1);
            gbSaleX.Controls.Add(rbtnSLCategory);
            gbSaleX.Controls.Add(rbtnSLOrigin);
            gbSaleX.Controls.Add(rbtnSLMember);
            gbSaleX.Controls.Add(rbtnSLProduct);
            gbSaleX.Controls.Add(cbSLOrigin);
            gbSaleX.Controls.Add(cbSLCategory);
            gbSaleX.Controls.Add(label4);
            gbSaleX.Controls.Add(cbSLProduct);
            gbSaleX.Controls.Add(btnSLYear);
            gbSaleX.Controls.Add(dtpSLTime1);
            gbSaleX.Controls.Add(btnSLMonth);
            gbSaleX.Controls.Add(lbSLTime2);
            gbSaleX.Controls.Add(btnSLWeek);
            gbSaleX.Controls.Add(dtpSLTime2);
            gbSaleX.Controls.Add(btnSLToday);
            gbSaleX.Location = new Point(6, 31);
            gbSaleX.Name = "gbSaleX";
            gbSaleX.Size = new Size(613, 211);
            gbSaleX.TabIndex = 74;
            gbSaleX.TabStop = false;
            gbSaleX.Text = "X軸";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(163, 138);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 28);
            radioButton1.TabIndex = 94;
            radioButton1.Text = "名稱";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(110, 138);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 28);
            radioButton2.TabIndex = 93;
            radioButton2.TabStop = true;
            radioButton2.Text = "ID";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // txbSLMember
            // 
            txbSLMember.BackColor = SystemColors.Window;
            txbSLMember.Location = new Point(110, 104);
            txbSLMember.MaxLength = 30;
            txbSLMember.Name = "txbSLMember";
            txbSLMember.Size = new Size(185, 32);
            txbSLMember.TabIndex = 92;
            // 
            // ckbSLTime1
            // 
            ckbSLTime1.AutoSize = true;
            ckbSLTime1.Location = new Point(39, 31);
            ckbSLTime1.Name = "ckbSLTime1";
            ckbSLTime1.Size = new Size(67, 28);
            ckbSLTime1.TabIndex = 90;
            ckbSLTime1.Text = "時間";
            ckbSLTime1.UseVisualStyleBackColor = true;
            // 
            // rbtnSLCategory
            // 
            rbtnSLCategory.AutoSize = true;
            rbtnSLCategory.Location = new Point(311, 166);
            rbtnSLCategory.Name = "rbtnSLCategory";
            rbtnSLCategory.Size = new Size(66, 28);
            rbtnSLCategory.TabIndex = 89;
            rbtnSLCategory.TabStop = true;
            rbtnSLCategory.Text = "種類";
            rbtnSLCategory.UseVisualStyleBackColor = true;
            // 
            // rbtnSLOrigin
            // 
            rbtnSLOrigin.AutoSize = true;
            rbtnSLOrigin.Location = new Point(311, 109);
            rbtnSLOrigin.Name = "rbtnSLOrigin";
            rbtnSLOrigin.Size = new Size(66, 28);
            rbtnSLOrigin.TabIndex = 88;
            rbtnSLOrigin.TabStop = true;
            rbtnSLOrigin.Text = "產地";
            rbtnSLOrigin.UseVisualStyleBackColor = true;
            // 
            // rbtnSLMember
            // 
            rbtnSLMember.AutoSize = true;
            rbtnSLMember.Location = new Point(38, 108);
            rbtnSLMember.Name = "rbtnSLMember";
            rbtnSLMember.Size = new Size(66, 28);
            rbtnSLMember.TabIndex = 87;
            rbtnSLMember.TabStop = true;
            rbtnSLMember.Text = "會員";
            rbtnSLMember.UseVisualStyleBackColor = true;
            // 
            // rbtnSLProduct
            // 
            rbtnSLProduct.AutoSize = true;
            rbtnSLProduct.Location = new Point(38, 166);
            rbtnSLProduct.Name = "rbtnSLProduct";
            rbtnSLProduct.Size = new Size(66, 28);
            rbtnSLProduct.TabIndex = 86;
            rbtnSLProduct.TabStop = true;
            rbtnSLProduct.Text = "產品";
            rbtnSLProduct.UseVisualStyleBackColor = true;
            // 
            // cbSLOrigin
            // 
            cbSLOrigin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSLOrigin.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSLOrigin.FormattingEnabled = true;
            cbSLOrigin.Location = new Point(384, 111);
            cbSLOrigin.Name = "cbSLOrigin";
            cbSLOrigin.Size = new Size(190, 28);
            cbSLOrigin.TabIndex = 81;
            // 
            // cbSLCategory
            // 
            cbSLCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSLCategory.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSLCategory.FormattingEnabled = true;
            cbSLCategory.Location = new Point(384, 168);
            cbSLCategory.Name = "cbSLCategory";
            cbSLCategory.Size = new Size(190, 28);
            cbSLCategory.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("微軟正黑體", 14.25F);
            label4.Location = new Point(52, 114);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 76;
            // 
            // cbSLProduct
            // 
            cbSLProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSLProduct.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbSLProduct.FormattingEnabled = true;
            cbSLProduct.Location = new Point(110, 168);
            cbSLProduct.Name = "cbSLProduct";
            cbSLProduct.Size = new Size(185, 28);
            cbSLProduct.TabIndex = 75;
            // 
            // btnSLYear
            // 
            btnSLYear.Font = new Font("Microsoft JhengHei UI", 11.25F);
            btnSLYear.Location = new Point(384, 58);
            btnSLYear.Name = "btnSLYear";
            btnSLYear.Size = new Size(63, 27);
            btnSLYear.TabIndex = 73;
            btnSLYear.Text = "今年";
            btnSLYear.UseVisualStyleBackColor = true;
            // 
            // dtpSLTime1
            // 
            dtpSLTime1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dtpSLTime1.Location = new Point(110, 26);
            dtpSLTime1.Name = "dtpSLTime1";
            dtpSLTime1.Size = new Size(185, 27);
            dtpSLTime1.TabIndex = 0;
            dtpSLTime1.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // btnSLMonth
            // 
            btnSLMonth.Font = new Font("Microsoft JhengHei UI", 11.25F);
            btnSLMonth.Location = new Point(315, 58);
            btnSLMonth.Name = "btnSLMonth";
            btnSLMonth.Size = new Size(63, 27);
            btnSLMonth.TabIndex = 72;
            btnSLMonth.Text = "本月";
            btnSLMonth.UseVisualStyleBackColor = true;
            // 
            // lbSLTime2
            // 
            lbSLTime2.AutoEllipsis = true;
            lbSLTime2.AutoSize = true;
            lbSLTime2.Font = new Font("微軟正黑體", 14.25F);
            lbSLTime2.Location = new Point(77, 61);
            lbSLTime2.Name = "lbSLTime2";
            lbSLTime2.Size = new Size(29, 24);
            lbSLTime2.TabIndex = 55;
            lbSLTime2.Text = "至";
            // 
            // btnSLWeek
            // 
            btnSLWeek.Font = new Font("Microsoft JhengHei UI", 11.25F);
            btnSLWeek.Location = new Point(384, 25);
            btnSLWeek.Name = "btnSLWeek";
            btnSLWeek.Size = new Size(63, 27);
            btnSLWeek.TabIndex = 71;
            btnSLWeek.Text = "本周";
            btnSLWeek.UseVisualStyleBackColor = true;
            // 
            // dtpSLTime2
            // 
            dtpSLTime2.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dtpSLTime2.Location = new Point(110, 59);
            dtpSLTime2.Name = "dtpSLTime2";
            dtpSLTime2.Size = new Size(185, 27);
            dtpSLTime2.TabIndex = 56;
            dtpSLTime2.Value = new DateTime(2024, 5, 19, 0, 0, 0, 0);
            // 
            // btnSLToday
            // 
            btnSLToday.Font = new Font("Microsoft JhengHei UI", 11.25F);
            btnSLToday.Location = new Point(315, 25);
            btnSLToday.Name = "btnSLToday";
            btnSLToday.Size = new Size(63, 27);
            btnSLToday.TabIndex = 70;
            btnSLToday.Text = "今天";
            btnSLToday.UseVisualStyleBackColor = true;
            // 
            // btnSLClear
            // 
            btnSLClear.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnSLClear.Location = new Point(846, 199);
            btnSLClear.Name = "btnSLClear";
            btnSLClear.Size = new Size(96, 43);
            btnSLClear.TabIndex = 32;
            btnSLClear.Text = "清除條件";
            btnSLClear.UseVisualStyleBackColor = true;
            btnSLClear.Click += btnSLClear_Click;
            // 
            // btnSLSearch
            // 
            btnSLSearch.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnSLSearch.Location = new Point(948, 199);
            btnSLSearch.Name = "btnSLSearch";
            btnSLSearch.Size = new Size(96, 43);
            btnSLSearch.TabIndex = 31;
            btnSLSearch.Text = "搜尋";
            btnSLSearch.UseVisualStyleBackColor = true;
            btnSLSearch.Click += btnSLSearch_Click;
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
            tbAddProduct.Text = "新增商品";
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
            txbTotal.ReadOnly = true;
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
            flp_shoppingCar.ControlAdded += flp_ControlChange;
            flp_shoppingCar.ControlRemoved += flp_ControlChange;
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
            // tbcControl
            // 
            tbcControl.Controls.Add(tbMemSerch);
            tbcControl.Controls.Add(tbAddProduct);
            tbcControl.Controls.Add(tbMenberEdit);
            tbcControl.Controls.Add(tbOrderHistory);
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
            btnAccountEdit.Click += btnAccountEdit_Click;
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
            txbOldPassword.MaxLength = 20;
            txbOldPassword.Name = "txbOldPassword";
            txbOldPassword.Size = new Size(170, 23);
            txbOldPassword.TabIndex = 24;
            txbOldPassword.KeyPress += checkPassword_KeyPress;
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
            txbCheck.MaxLength = 20;
            txbCheck.Name = "txbCheck";
            txbCheck.Size = new Size(170, 23);
            txbCheck.TabIndex = 22;
            txbCheck.KeyPress += checkPassword_KeyPress;
            // 
            // lbCheck
            // 
            lbCheck.AutoEllipsis = true;
            lbCheck.AutoSize = true;
            lbCheck.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbCheck.Location = new Point(40, 643);
            lbCheck.Name = "lbCheck";
            lbCheck.Size = new Size(86, 24);
            lbCheck.TabIndex = 21;
            lbCheck.Text = "確認密碼";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(143, 586);
            txbPassword.MaxLength = 20;
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(170, 23);
            txbPassword.TabIndex = 20;
            txbPassword.KeyPress += checkPassword_KeyPress;
            // 
            // lbPassword
            // 
            lbPassword.AutoEllipsis = true;
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbPassword.Location = new Point(59, 585);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(67, 24);
            lbPassword.TabIndex = 19;
            lbPassword.Text = "新密碼";
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
            // tbOrderHistory
            // 
            tbOrderHistory.Controls.Add(lbOdrIsRead);
            tbOrderHistory.Controls.Add(lbOdrIsConfirmed);
            tbOrderHistory.Controls.Add(btnOdrCancelOdr);
            tbOrderHistory.Controls.Add(btnOdrComment);
            tbOrderHistory.Controls.Add(ptbOdr);
            tbOrderHistory.Controls.Add(txbOdr_Total);
            tbOrderHistory.Controls.Add(lbOdr_RName);
            tbOrderHistory.Controls.Add(lbOdr_OName);
            tbOrderHistory.Controls.Add(lbOdr_RAddress);
            tbOrderHistory.Controls.Add(txbOdr_RAdress);
            tbOrderHistory.Controls.Add(lbOdr_OAddress);
            tbOrderHistory.Controls.Add(lbOdr_Payment);
            tbOrderHistory.Controls.Add(txbOdr_OAdress);
            tbOrderHistory.Controls.Add(lbOdr_date);
            tbOrderHistory.Controls.Add(flpOdr_Histroy);
            tbOrderHistory.Controls.Add(lbOdr_Histroy);
            tbOrderHistory.Controls.Add(cbOdr_Number);
            tbOrderHistory.Controls.Add(lbOdr_Number);
            tbOrderHistory.Location = new Point(4, 24);
            tbOrderHistory.Name = "tbOrderHistory";
            tbOrderHistory.Padding = new Padding(3);
            tbOrderHistory.Size = new Size(462, 754);
            tbOrderHistory.TabIndex = 3;
            tbOrderHistory.Tag = "3";
            tbOrderHistory.Text = "歷史訂單";
            tbOrderHistory.UseVisualStyleBackColor = true;
            // 
            // lbOdrIsRead
            // 
            lbOdrIsRead.AutoSize = true;
            lbOdrIsRead.ForeColor = Color.FromArgb(192, 0, 0);
            lbOdrIsRead.Location = new Point(166, 360);
            lbOdrIsRead.Name = "lbOdrIsRead";
            lbOdrIsRead.Size = new Size(67, 15);
            lbOdrIsRead.TabIndex = 62;
            lbOdrIsRead.Text = "有未讀訊息";
            // 
            // lbOdrIsConfirmed
            // 
            lbOdrIsConfirmed.AutoSize = true;
            lbOdrIsConfirmed.Location = new Point(22, 360);
            lbOdrIsConfirmed.Name = "lbOdrIsConfirmed";
            lbOdrIsConfirmed.Size = new Size(91, 15);
            lbOdrIsConfirmed.TabIndex = 61;
            lbOdrIsConfirmed.Text = "賣家未確認訂單";
            lbOdrIsConfirmed.Visible = false;
            // 
            // btnOdrCancelOdr
            // 
            btnOdrCancelOdr.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnOdrCancelOdr.Location = new Point(239, 345);
            btnOdrCancelOdr.Name = "btnOdrCancelOdr";
            btnOdrCancelOdr.Size = new Size(96, 43);
            btnOdrCancelOdr.TabIndex = 45;
            btnOdrCancelOdr.Text = "取消訂單";
            btnOdrCancelOdr.UseVisualStyleBackColor = true;
            btnOdrCancelOdr.Click += btnOdrCancelOdr_Click;
            // 
            // btnOdrComment
            // 
            btnOdrComment.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnOdrComment.Location = new Point(341, 345);
            btnOdrComment.Name = "btnOdrComment";
            btnOdrComment.Size = new Size(96, 43);
            btnOdrComment.TabIndex = 44;
            btnOdrComment.Text = "訊息";
            btnOdrComment.UseVisualStyleBackColor = true;
            btnOdrComment.Click += btnOdrComment_Click;
            // 
            // ptbOdr
            // 
            ptbOdr.BackColor = Color.Transparent;
            ptbOdr.Image = Properties.Resources.file;
            ptbOdr.Location = new Point(285, 16);
            ptbOdr.Name = "ptbOdr";
            ptbOdr.Size = new Size(152, 128);
            ptbOdr.TabIndex = 43;
            ptbOdr.TabStop = false;
            // 
            // txbOdr_Total
            // 
            txbOdr_Total.BackColor = SystemColors.Window;
            txbOdr_Total.BorderStyle = BorderStyle.None;
            txbOdr_Total.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbOdr_Total.Location = new Point(261, 194);
            txbOdr_Total.Name = "txbOdr_Total";
            txbOdr_Total.ReadOnly = true;
            txbOdr_Total.Size = new Size(176, 31);
            txbOdr_Total.TabIndex = 42;
            txbOdr_Total.TextAlign = HorizontalAlignment.Right;
            // 
            // lbOdr_RName
            // 
            lbOdr_RName.AutoEllipsis = true;
            lbOdr_RName.AutoSize = true;
            lbOdr_RName.Font = new Font("新細明體", 12F);
            lbOdr_RName.Location = new Point(22, 290);
            lbOdr_RName.Name = "lbOdr_RName";
            lbOdr_RName.Size = new Size(95, 16);
            lbOdr_RName.TabIndex = 41;
            lbOdr_RName.Text = "收貨人姓名 :";
            // 
            // lbOdr_OName
            // 
            lbOdr_OName.AutoEllipsis = true;
            lbOdr_OName.AutoSize = true;
            lbOdr_OName.Font = new Font("新細明體", 12F);
            lbOdr_OName.Location = new Point(22, 230);
            lbOdr_OName.Name = "lbOdr_OName";
            lbOdr_OName.Size = new Size(95, 16);
            lbOdr_OName.TabIndex = 40;
            lbOdr_OName.Text = "訂購人姓名 :";
            // 
            // lbOdr_RAddress
            // 
            lbOdr_RAddress.AutoEllipsis = true;
            lbOdr_RAddress.AutoSize = true;
            lbOdr_RAddress.Font = new Font("新細明體", 12F);
            lbOdr_RAddress.Location = new Point(22, 320);
            lbOdr_RAddress.Name = "lbOdr_RAddress";
            lbOdr_RAddress.Size = new Size(95, 16);
            lbOdr_RAddress.TabIndex = 39;
            lbOdr_RAddress.Text = "收貨人地址 :";
            // 
            // txbOdr_RAdress
            // 
            txbOdr_RAdress.BackColor = SystemColors.Window;
            txbOdr_RAdress.BorderStyle = BorderStyle.None;
            txbOdr_RAdress.Font = new Font("新細明體", 12F);
            txbOdr_RAdress.Location = new Point(114, 320);
            txbOdr_RAdress.Name = "txbOdr_RAdress";
            txbOdr_RAdress.ReadOnly = true;
            txbOdr_RAdress.RightToLeft = RightToLeft.Yes;
            txbOdr_RAdress.Size = new Size(295, 20);
            txbOdr_RAdress.TabIndex = 38;
            txbOdr_RAdress.TextAlign = HorizontalAlignment.Right;
            txbOdr_RAdress.TextChanged += lb_TextChanged;
            // 
            // lbOdr_OAddress
            // 
            lbOdr_OAddress.AutoEllipsis = true;
            lbOdr_OAddress.AutoSize = true;
            lbOdr_OAddress.Font = new Font("新細明體", 12F);
            lbOdr_OAddress.Location = new Point(22, 260);
            lbOdr_OAddress.Name = "lbOdr_OAddress";
            lbOdr_OAddress.Size = new Size(95, 16);
            lbOdr_OAddress.TabIndex = 37;
            lbOdr_OAddress.Text = "訂購人地址 :";
            // 
            // lbOdr_Payment
            // 
            lbOdr_Payment.AutoEllipsis = true;
            lbOdr_Payment.AutoSize = true;
            lbOdr_Payment.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdr_Payment.Location = new Point(22, 194);
            lbOdr_Payment.Name = "lbOdr_Payment";
            lbOdr_Payment.Size = new Size(95, 24);
            lbOdr_Payment.TabIndex = 36;
            lbOdr_Payment.Text = "付款方式 :";
            // 
            // txbOdr_OAdress
            // 
            txbOdr_OAdress.BackColor = SystemColors.Window;
            txbOdr_OAdress.BorderStyle = BorderStyle.None;
            txbOdr_OAdress.Font = new Font("新細明體", 12F);
            txbOdr_OAdress.Location = new Point(114, 260);
            txbOdr_OAdress.Name = "txbOdr_OAdress";
            txbOdr_OAdress.ReadOnly = true;
            txbOdr_OAdress.RightToLeft = RightToLeft.Yes;
            txbOdr_OAdress.Size = new Size(295, 20);
            txbOdr_OAdress.TabIndex = 35;
            txbOdr_OAdress.TextAlign = HorizontalAlignment.Right;
            txbOdr_OAdress.TextChanged += lb_TextChanged;
            // 
            // lbOdr_date
            // 
            lbOdr_date.AutoEllipsis = true;
            lbOdr_date.AutoSize = true;
            lbOdr_date.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdr_date.Location = new Point(22, 157);
            lbOdr_date.Name = "lbOdr_date";
            lbOdr_date.Size = new Size(95, 24);
            lbOdr_date.TabIndex = 33;
            lbOdr_date.Text = "訂購日期 :";
            // 
            // flpOdr_Histroy
            // 
            flpOdr_Histroy.AutoScroll = true;
            flpOdr_Histroy.BackgroundImage = Properties.Resources.shopping_cart2;
            flpOdr_Histroy.BackgroundImageLayout = ImageLayout.Center;
            flpOdr_Histroy.BorderStyle = BorderStyle.FixedSingle;
            flpOdr_Histroy.Location = new Point(6, 394);
            flpOdr_Histroy.Name = "flpOdr_Histroy";
            flpOdr_Histroy.Size = new Size(431, 357);
            flpOdr_Histroy.TabIndex = 32;
            flpOdr_Histroy.ControlAdded += flp_ControlChange;
            // 
            // lbOdr_Histroy
            // 
            lbOdr_Histroy.AutoSize = true;
            lbOdr_Histroy.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbOdr_Histroy.Location = new Point(39, 48);
            lbOdr_Histroy.Name = "lbOdr_Histroy";
            lbOdr_Histroy.Size = new Size(210, 41);
            lbOdr_Histroy.TabIndex = 14;
            lbOdr_Histroy.Text = "歷史訂單查詢";
            // 
            // cbOdr_Number
            // 
            cbOdr_Number.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOdr_Number.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbOdr_Number.FormattingEnabled = true;
            cbOdr_Number.Location = new Point(114, 120);
            cbOdr_Number.Name = "cbOdr_Number";
            cbOdr_Number.Size = new Size(159, 28);
            cbOdr_Number.TabIndex = 12;
            cbOdr_Number.SelectedIndexChanged += cbOdr_Number_SelectedIndexChanged;
            // 
            // lbOdr_Number
            // 
            lbOdr_Number.AutoEllipsis = true;
            lbOdr_Number.AutoSize = true;
            lbOdr_Number.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdr_Number.Location = new Point(22, 120);
            lbOdr_Number.Name = "lbOdr_Number";
            lbOdr_Number.Size = new Size(86, 24);
            lbOdr_Number.TabIndex = 13;
            lbOdr_Number.Text = "訂單編號";
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
            tbUnshelve.ResumeLayout(false);
            tbUnshelve.PerformLayout();
            tbOrderMan.ResumeLayout(false);
            tbOrderMan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr_Confirmed).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr_IsCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr_unConfirmed).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr_isRead).EndInit();
            gbOdrSearch.ResumeLayout(false);
            gbOdrSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbOdrSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr).EndInit();
            tbSale.ResumeLayout(false);
            tbSale.PerformLayout();
            gbSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbSale).EndInit();
            gbSaleY.ResumeLayout(false);
            gbSaleY.PerformLayout();
            gbSaleX.ResumeLayout(false);
            gbSaleX.PerformLayout();
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
            tbOrderHistory.ResumeLayout(false);
            tbOrderHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbOdr).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TabPage tbOrderHistory;
        private FlowLayoutPanel flpOdr_Histroy;
        private Label lbOdr_Histroy;
        private ComboBox cbOdr_Number;
        private Label lbOdr_Number;
        private TextBox txbOdr_OAdress;
        private Label lbOdr_date;
        private Label lbOdr_Payment;
        private Label lbOdr_OAddress;
        private Label lbOdr_RName;
        private Label lbOdr_OName;
        private Label lbOdr_RAddress;
        private TextBox txbOdr_RAdress;
        private TextBox txbOdr_Total;
        private PictureBox ptbOdr;
        private TabPage tbUnshelve;
        private ProductCard productCard9;
        private ProductCard productCard10;
        private ProductCard productCard11;
        private ProductCard productCard12;
        private ProductCard productCard13;
        private ProductCard productCard14;
        private ProductCard productCard15;
        private ProductCard productCard16;
        private Label lbUnPage;
        private ComboBox cbUnPage;
        private Button btnUnBackPage;
        private Button btnUnNextPage;
        private PictureBox ptbMOdr;
        private TextBox txbMOdr_Total;
        private Label lbMOdr_RName;
        private Label lbMOdr_OName;
        private Label lbMOdr_RAddress;
        private TextBox txbMOdr_RAddress;
        private Label lbMOdr_OAddress;
        private Label lbMOdr_Payment;
        private TextBox txbMOdr_OAddress;
        private Label lbMOdr_Date;
        private FlowLayoutPanel flpMOdr;
        private Label lbMOdr;
        private ComboBox cbMOdr_Number;
        private Label lbMOdr_Number;
        private Button btnMOdrConfirmed;
        private Button btnMOdrMessage;
        private Label lbMOdr_IsRead;
        private Button btnMOdrCancel;
        private Button btnOdrComment;
        private Button btnOdrCancelOdr;
        private Label lbOdrIsRead;
        private Label lbOdrIsConfirmed;
        private TabPage tbOrderMan;
        private GroupBox gbOdrSearch;
        private TextBox txbOdrSName;
        private Label lbOdrSName;
        private DateTimePicker dtpOdrTime2;
        private Label lbTime2;
        private Label lbTime;
        private Button btnOdrClear;
        private Button btnOdrSearch;
        private DateTimePicker dtpOdrTime;
        private ComboBox cbOdrSPayMent;
        private Label lbOdrSPayMent;
        private Label lbOdrSProduct;
        private ComboBox cbOdrSIsConfirmed;
        private Label lbOdrSIsConfirmed;
        private ComboBox cbOdrSIsCancel;
        private Label lbOdrSIsCancel;
        private PictureBox ptbOdrSearch;
        private RadioButton rbtnOdrSName;
        private RadioButton rbtnOdrSId;
        private ComboBox cbOdrSProduct;
        private Label lbMOdr_unConfirmed;
        private Label lbMOdr_IsCancel;
        private PictureBox ptbMOdr_isRead;
        private PictureBox ptbMOdr_IsCancel;
        private PictureBox ptbMOdr_unConfirmed;
        private PictureBox ptbMOdr_Confirmed;
        private Label lbMOdr_Confirmed;
        private Button btnOdrYear;
        private Button btnOdrMonth;
        private Button btnOdrWeek;
        private Button btnOdrToday;
        private ComboBox cbOdrSIsRead;
        private Label lbOdrSIsRead;
        private TabPage tbSale;
        private Label lbSale;
        private GroupBox gbSale;
        private Button btnSLYear;
        private Button btnSLMonth;
        private Button btnSLWeek;
        private Button btnSLToday;
        private DateTimePicker dtpSLTime2;
        private Label lbSLTime2;
        private Button btnSLClear;
        private Button btnSLSearch;
        private DateTimePicker dtpSLTime1;
        private OxyPlot.WindowsForms.PlotView ptvSL;
        private GroupBox gbSaleY;
        private GroupBox gbSaleX;
        private ComboBox cbSLCategory;
        private Label label4;
        private ComboBox cbSLProduct;
        private ComboBox cbSLOrigin;
        private PictureBox ptbSale;
        private RadioButton rbtnSLOrderCount;
        private RadioButton rbtnSLTatal;
        private RadioButton rbtnSLQuantity;
        private RadioButton rbtnSLCategory;
        private RadioButton rbtnSLOrigin;
        private RadioButton rbtnSLMember;
        private RadioButton rbtnSLProduct;
        private CheckBox ckbSLTime1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox txbSLMember;
        private Button btn_test;
    }
}
