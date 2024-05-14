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
            tbOrderHistory = new TabPage();
            pictureBox2 = new PictureBox();
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
            tbMemOrder = new TabPage();
            ptbMOdr = new PictureBox();
            txbMOdr_Total = new TextBox();
            lbMOdr_RName = new Label();
            lbMOdr_OName = new Label();
            lbMOdr_RAddress = new Label();
            txbMOdr_RAddress = new TextBox();
            lbMOdr_OAddress = new Label();
            lbMOdr_Patment = new Label();
            txbMOdr_OAddress = new TextBox();
            lbMOdr_Date = new Label();
            flpMOdr = new FlowLayoutPanel();
            lbMOdr = new Label();
            cbMOdr_Number = new ComboBox();
            lbMOdr_Number = new Label();
            button1 = new Button();
            tbcProdut.SuspendLayout();
            tbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Sort).BeginInit();
            tbUnshelve.SuspendLayout();
            tbAddProduct.SuspendLayout();
            tbMemSerch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Buy).BeginInit();
            tbcControl.SuspendLayout();
            tbMenberEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMember).BeginInit();
            tbOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tbMemOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr).BeginInit();
            SuspendLayout();
            // 
            // tbcProdut
            // 
            tbcProdut.Controls.Add(tbProduct);
            tbcProdut.Controls.Add(tbUnshelve);
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
            tbcControl.Controls.Add(tbOrderHistory);
            tbcControl.Controls.Add(tbMemOrder);
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
            tbOrderHistory.Controls.Add(pictureBox2);
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.file;
            pictureBox2.Location = new Point(285, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 128);
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
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
            lbOdr_RName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdr_RName.Location = new Point(22, 300);
            lbOdr_RName.Name = "lbOdr_RName";
            lbOdr_RName.Size = new Size(114, 24);
            lbOdr_RName.TabIndex = 41;
            lbOdr_RName.Text = "收貨人姓名 :";
            // 
            // lbOdr_OName
            // 
            lbOdr_OName.AutoEllipsis = true;
            lbOdr_OName.AutoSize = true;
            lbOdr_OName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdr_OName.Location = new Point(22, 229);
            lbOdr_OName.Name = "lbOdr_OName";
            lbOdr_OName.Size = new Size(114, 24);
            lbOdr_OName.TabIndex = 40;
            lbOdr_OName.Text = "訂購人姓名 :";
            // 
            // lbOdr_RAddress
            // 
            lbOdr_RAddress.AutoEllipsis = true;
            lbOdr_RAddress.AutoSize = true;
            lbOdr_RAddress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdr_RAddress.Location = new Point(22, 335);
            lbOdr_RAddress.Name = "lbOdr_RAddress";
            lbOdr_RAddress.Size = new Size(114, 24);
            lbOdr_RAddress.TabIndex = 39;
            lbOdr_RAddress.Text = "收貨人地址 :";
            // 
            // txbOdr_RAdress
            // 
            txbOdr_RAdress.BackColor = SystemColors.Window;
            txbOdr_RAdress.BorderStyle = BorderStyle.None;
            txbOdr_RAdress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbOdr_RAdress.Location = new Point(142, 330);
            txbOdr_RAdress.Name = "txbOdr_RAdress";
            txbOdr_RAdress.ReadOnly = true;
            txbOdr_RAdress.RightToLeft = RightToLeft.Yes;
            txbOdr_RAdress.Size = new Size(295, 25);
            txbOdr_RAdress.TabIndex = 38;
            txbOdr_RAdress.TextAlign = HorizontalAlignment.Right;
            txbOdr_RAdress.TextChanged += lb_TextChanged;
            // 
            // lbOdr_OAddress
            // 
            lbOdr_OAddress.AutoEllipsis = true;
            lbOdr_OAddress.AutoSize = true;
            lbOdr_OAddress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOdr_OAddress.Location = new Point(22, 266);
            lbOdr_OAddress.Name = "lbOdr_OAddress";
            lbOdr_OAddress.Size = new Size(114, 24);
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
            txbOdr_OAdress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbOdr_OAdress.Location = new Point(142, 261);
            txbOdr_OAdress.Name = "txbOdr_OAdress";
            txbOdr_OAdress.ReadOnly = true;
            txbOdr_OAdress.RightToLeft = RightToLeft.Yes;
            txbOdr_OAdress.Size = new Size(295, 25);
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
            flpOdr_Histroy.Location = new Point(6, 382);
            flpOdr_Histroy.Name = "flpOdr_Histroy";
            flpOdr_Histroy.Size = new Size(431, 369);
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
            // tbMemOrder
            // 
            tbMemOrder.Controls.Add(button1);
            tbMemOrder.Controls.Add(ptbMOdr);
            tbMemOrder.Controls.Add(txbMOdr_Total);
            tbMemOrder.Controls.Add(lbMOdr_RName);
            tbMemOrder.Controls.Add(lbMOdr_OName);
            tbMemOrder.Controls.Add(lbMOdr_RAddress);
            tbMemOrder.Controls.Add(txbMOdr_RAddress);
            tbMemOrder.Controls.Add(lbMOdr_OAddress);
            tbMemOrder.Controls.Add(lbMOdr_Patment);
            tbMemOrder.Controls.Add(txbMOdr_OAddress);
            tbMemOrder.Controls.Add(lbMOdr_Date);
            tbMemOrder.Controls.Add(flpMOdr);
            tbMemOrder.Controls.Add(lbMOdr);
            tbMemOrder.Controls.Add(cbMOdr_Number);
            tbMemOrder.Controls.Add(lbMOdr_Number);
            tbMemOrder.Location = new Point(4, 24);
            tbMemOrder.Name = "tbMemOrder";
            tbMemOrder.Padding = new Padding(3);
            tbMemOrder.Size = new Size(462, 754);
            tbMemOrder.TabIndex = 4;
            tbMemOrder.Text = "訂單確認";
            tbMemOrder.UseVisualStyleBackColor = true;
            // 
            // ptbMOdr
            // 
            ptbMOdr.Image = Properties.Resources.clipboard;
            ptbMOdr.Location = new Point(295, 10);
            ptbMOdr.Name = "ptbMOdr";
            ptbMOdr.Size = new Size(152, 128);
            ptbMOdr.TabIndex = 57;
            ptbMOdr.TabStop = false;
            // 
            // txbMOdr_Total
            // 
            txbMOdr_Total.BackColor = SystemColors.Window;
            txbMOdr_Total.BorderStyle = BorderStyle.None;
            txbMOdr_Total.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbMOdr_Total.Location = new Point(271, 188);
            txbMOdr_Total.Name = "txbMOdr_Total";
            txbMOdr_Total.ReadOnly = true;
            txbMOdr_Total.Size = new Size(176, 31);
            txbMOdr_Total.TabIndex = 56;
            txbMOdr_Total.TextAlign = HorizontalAlignment.Right;
            // 
            // lbMOdr_RName
            // 
            lbMOdr_RName.AutoEllipsis = true;
            lbMOdr_RName.AutoSize = true;
            lbMOdr_RName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_RName.Location = new Point(32, 294);
            lbMOdr_RName.Name = "lbMOdr_RName";
            lbMOdr_RName.Size = new Size(114, 24);
            lbMOdr_RName.TabIndex = 55;
            lbMOdr_RName.Text = "收貨人姓名 :";
            // 
            // lbMOdr_OName
            // 
            lbMOdr_OName.AutoEllipsis = true;
            lbMOdr_OName.AutoSize = true;
            lbMOdr_OName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_OName.Location = new Point(32, 223);
            lbMOdr_OName.Name = "lbMOdr_OName";
            lbMOdr_OName.Size = new Size(114, 24);
            lbMOdr_OName.TabIndex = 54;
            lbMOdr_OName.Text = "訂購人姓名 :";
            // 
            // lbMOdr_RAddress
            // 
            lbMOdr_RAddress.AutoEllipsis = true;
            lbMOdr_RAddress.AutoSize = true;
            lbMOdr_RAddress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_RAddress.Location = new Point(32, 329);
            lbMOdr_RAddress.Name = "lbMOdr_RAddress";
            lbMOdr_RAddress.Size = new Size(114, 24);
            lbMOdr_RAddress.TabIndex = 53;
            lbMOdr_RAddress.Text = "收貨人地址 :";
            // 
            // txbMOdr_RAddress
            // 
            txbMOdr_RAddress.BackColor = SystemColors.Window;
            txbMOdr_RAddress.BorderStyle = BorderStyle.None;
            txbMOdr_RAddress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbMOdr_RAddress.Location = new Point(152, 324);
            txbMOdr_RAddress.Name = "txbMOdr_RAddress";
            txbMOdr_RAddress.ReadOnly = true;
            txbMOdr_RAddress.RightToLeft = RightToLeft.Yes;
            txbMOdr_RAddress.Size = new Size(295, 25);
            txbMOdr_RAddress.TabIndex = 52;
            txbMOdr_RAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // lbMOdr_OAddress
            // 
            lbMOdr_OAddress.AutoEllipsis = true;
            lbMOdr_OAddress.AutoSize = true;
            lbMOdr_OAddress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_OAddress.Location = new Point(32, 260);
            lbMOdr_OAddress.Name = "lbMOdr_OAddress";
            lbMOdr_OAddress.Size = new Size(114, 24);
            lbMOdr_OAddress.TabIndex = 51;
            lbMOdr_OAddress.Text = "訂購人地址 :";
            // 
            // lbMOdr_Patment
            // 
            lbMOdr_Patment.AutoEllipsis = true;
            lbMOdr_Patment.AutoSize = true;
            lbMOdr_Patment.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_Patment.Location = new Point(32, 188);
            lbMOdr_Patment.Name = "lbMOdr_Patment";
            lbMOdr_Patment.Size = new Size(95, 24);
            lbMOdr_Patment.TabIndex = 50;
            lbMOdr_Patment.Text = "付款方式 :";
            // 
            // txbMOdr_OAddress
            // 
            txbMOdr_OAddress.BackColor = SystemColors.Window;
            txbMOdr_OAddress.BorderStyle = BorderStyle.None;
            txbMOdr_OAddress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbMOdr_OAddress.Location = new Point(152, 255);
            txbMOdr_OAddress.Name = "txbMOdr_OAddress";
            txbMOdr_OAddress.ReadOnly = true;
            txbMOdr_OAddress.RightToLeft = RightToLeft.Yes;
            txbMOdr_OAddress.Size = new Size(295, 25);
            txbMOdr_OAddress.TabIndex = 49;
            txbMOdr_OAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // lbMOdr_Date
            // 
            lbMOdr_Date.AutoEllipsis = true;
            lbMOdr_Date.AutoSize = true;
            lbMOdr_Date.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_Date.Location = new Point(32, 151);
            lbMOdr_Date.Name = "lbMOdr_Date";
            lbMOdr_Date.Size = new Size(95, 24);
            lbMOdr_Date.TabIndex = 48;
            lbMOdr_Date.Text = "訂購日期 :";
            // 
            // flpMOdr
            // 
            flpMOdr.AutoScroll = true;
            flpMOdr.BackgroundImage = Properties.Resources.shopping_cart2;
            flpMOdr.BackgroundImageLayout = ImageLayout.Center;
            flpMOdr.BorderStyle = BorderStyle.FixedSingle;
            flpMOdr.Location = new Point(16, 376);
            flpMOdr.Name = "flpMOdr";
            flpMOdr.Size = new Size(431, 328);
            flpMOdr.TabIndex = 47;
            // 
            // lbMOdr
            // 
            lbMOdr.AutoSize = true;
            lbMOdr.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbMOdr.Location = new Point(32, 41);
            lbMOdr.Name = "lbMOdr";
            lbMOdr.Size = new Size(146, 41);
            lbMOdr.TabIndex = 46;
            lbMOdr.Text = "訂單確認";
            // 
            // cbMOdr_Number
            // 
            cbMOdr_Number.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMOdr_Number.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbMOdr_Number.FormattingEnabled = true;
            cbMOdr_Number.Location = new Point(124, 114);
            cbMOdr_Number.Name = "cbMOdr_Number";
            cbMOdr_Number.Size = new Size(159, 28);
            cbMOdr_Number.TabIndex = 44;
            // 
            // lbMOdr_Number
            // 
            lbMOdr_Number.AutoEllipsis = true;
            lbMOdr_Number.AutoSize = true;
            lbMOdr_Number.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMOdr_Number.Location = new Point(32, 114);
            lbMOdr_Number.Name = "lbMOdr_Number";
            lbMOdr_Number.Size = new Size(86, 24);
            lbMOdr_Number.TabIndex = 45;
            lbMOdr_Number.Text = "訂單編號";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(351, 708);
            button1.Name = "button1";
            button1.Size = new Size(96, 43);
            button1.TabIndex = 58;
            button1.Text = "下一頁";
            button1.UseVisualStyleBackColor = true;
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
            tbUnshelve.ResumeLayout(false);
            tbUnshelve.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tbMemOrder.ResumeLayout(false);
            tbMemOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMOdr).EndInit();
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
        private PictureBox pictureBox2;
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
        private TabPage tbMemOrder;
        private PictureBox ptbMOdr;
        private TextBox txbMOdr_Total;
        private Label lbMOdr_RName;
        private Label lbMOdr_OName;
        private Label lbMOdr_RAddress;
        private TextBox txbMOdr_RAddress;
        private Label lbMOdr_OAddress;
        private Label lbMOdr_Patment;
        private TextBox txbMOdr_OAddress;
        private Label lbMOdr_Date;
        private FlowLayoutPanel flpMOdr;
        private Label lbMOdr;
        private ComboBox cbMOdr_Number;
        private Label lbMOdr_Number;
        private Button button1;
    }
}
