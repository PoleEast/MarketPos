namespace MarketPos.FormPage.Manager
{
    partial class Mem_Detail_PCard
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
            lbQuantity = new Label();
            lbOrigin = new Label();
            lbWeight = new Label();
            lbPrice = new Label();
            lbCategory = new Label();
            lbName = new Label();
            ptbProduct = new PictureBox();
            txbName = new TextBox();
            cbCategory = new ComboBox();
            rtbDescription = new RichTextBox();
            txbWeight = new TextBox();
            label1 = new Label();
            txbPrice = new TextBox();
            cbOrigin = new ComboBox();
            ckbShelve = new CheckBox();
            btnChange = new Button();
            txbStock = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbProduct).BeginInit();
            SuspendLayout();
            // 
            // lbQuantity
            // 
            lbQuantity.AutoEllipsis = true;
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbQuantity.Location = new Point(660, 77);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(57, 24);
            lbQuantity.TabIndex = 50;
            lbQuantity.Text = "庫存 :";
            // 
            // lbOrigin
            // 
            lbOrigin.AutoEllipsis = true;
            lbOrigin.AutoSize = true;
            lbOrigin.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOrigin.Location = new Point(446, 77);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new Size(62, 24);
            lbOrigin.TabIndex = 45;
            lbOrigin.Text = "產地 : ";
            // 
            // lbWeight
            // 
            lbWeight.AutoEllipsis = true;
            lbWeight.AutoSize = true;
            lbWeight.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbWeight.Location = new Point(446, 157);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(62, 24);
            lbWeight.TabIndex = 44;
            lbWeight.Text = "重量 : ";
            // 
            // lbPrice
            // 
            lbPrice.AutoEllipsis = true;
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbPrice.Location = new Point(446, 406);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(75, 35);
            lbPrice.TabIndex = 43;
            lbPrice.Text = "價格:";
            // 
            // lbCategory
            // 
            lbCategory.AutoEllipsis = true;
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbCategory.Location = new Point(446, 118);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(62, 24);
            lbCategory.TabIndex = 42;
            lbCategory.Text = "種類 : ";
            // 
            // lbName
            // 
            lbName.AutoEllipsis = true;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbName.Location = new Point(438, 25);
            lbName.Name = "lbName";
            lbName.Size = new Size(90, 35);
            lbName.TabIndex = 41;
            lbName.Text = "名稱 : ";
            // 
            // ptbProduct
            // 
            ptbProduct.Location = new Point(12, 11);
            ptbProduct.Name = "ptbProduct";
            ptbProduct.Size = new Size(420, 389);
            ptbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbProduct.TabIndex = 40;
            ptbProduct.TabStop = false;
            // 
            // txbName
            // 
            txbName.Cursor = Cursors.IBeam;
            txbName.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbName.Location = new Point(522, 22);
            txbName.Name = "txbName";
            txbName.Size = new Size(266, 41);
            txbName.TabIndex = 52;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(514, 115);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(140, 32);
            cbCategory.TabIndex = 54;
            // 
            // rtbDescription
            // 
            rtbDescription.Cursor = Cursors.IBeam;
            rtbDescription.Location = new Point(446, 201);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(342, 198);
            rtbDescription.TabIndex = 55;
            rtbDescription.Text = "";
            // 
            // txbWeight
            // 
            txbWeight.Cursor = Cursors.IBeam;
            txbWeight.Font = new Font("Microsoft JhengHei UI", 14F);
            txbWeight.Location = new Point(514, 154);
            txbWeight.MaxLength = 6;
            txbWeight.Name = "txbWeight";
            txbWeight.Size = new Size(140, 31);
            txbWeight.TabIndex = 56;
            txbWeight.KeyPress += checkNum_KeyPress;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(660, 167);
            label1.Name = "label1";
            label1.Size = new Size(29, 14);
            label1.TabIndex = 57;
            label1.Text = "公克";
            // 
            // txbPrice
            // 
            txbPrice.Cursor = Cursors.IBeam;
            txbPrice.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbPrice.Location = new Point(522, 403);
            txbPrice.MaxLength = 8;
            txbPrice.Name = "txbPrice";
            txbPrice.Size = new Size(132, 42);
            txbPrice.TabIndex = 58;
            txbPrice.KeyPress += checkNum_KeyPress;
            // 
            // cbOrigin
            // 
            cbOrigin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrigin.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbOrigin.FormattingEnabled = true;
            cbOrigin.Location = new Point(514, 74);
            cbOrigin.Name = "cbOrigin";
            cbOrigin.Size = new Size(140, 32);
            cbOrigin.TabIndex = 59;
            // 
            // ckbShelve
            // 
            ckbShelve.AutoSize = true;
            ckbShelve.Cursor = Cursors.Hand;
            ckbShelve.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            ckbShelve.Location = new Point(716, 158);
            ckbShelve.Name = "ckbShelve";
            ckbShelve.Size = new Size(67, 28);
            ckbShelve.TabIndex = 61;
            ckbShelve.Text = "上架";
            ckbShelve.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnChange.Location = new Point(692, 402);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(96, 43);
            btnChange.TabIndex = 62;
            btnChange.Text = "確認更改";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // txbStock
            // 
            txbStock.Cursor = Cursors.IBeam;
            txbStock.Font = new Font("Microsoft JhengHei UI", 14F);
            txbStock.Location = new Point(716, 74);
            txbStock.MaxLength = 6;
            txbStock.Name = "txbStock";
            txbStock.Size = new Size(72, 31);
            txbStock.TabIndex = 63;
            txbStock.KeyPress += checkNum_KeyPress;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(655, 406);
            label2.Name = "label2";
            label2.Size = new Size(31, 35);
            label2.TabIndex = 64;
            label2.Text = "$";
            // 
            // Mem_Detail_PCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txbStock);
            Controls.Add(btnChange);
            Controls.Add(ckbShelve);
            Controls.Add(cbOrigin);
            Controls.Add(txbPrice);
            Controls.Add(label1);
            Controls.Add(txbWeight);
            Controls.Add(rtbDescription);
            Controls.Add(cbCategory);
            Controls.Add(txbName);
            Controls.Add(lbQuantity);
            Controls.Add(lbOrigin);
            Controls.Add(lbWeight);
            Controls.Add(lbPrice);
            Controls.Add(lbCategory);
            Controls.Add(lbName);
            Controls.Add(ptbProduct);
            Name = "Mem_Detail_PCard";
            Text = "M_Detail_PCard";
            Load += Mem_Detail_PCard_Load;
            ((System.ComponentModel.ISupportInitialize)ptbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbQuantity;
        private Label lbOrigin;
        private Label lbWeight;
        private Label lbPrice;
        private Label lbCategory;
        private Label lbName;
        private PictureBox ptbProduct;
        private TextBox txbName;
        private ComboBox cbCategory;
        private RichTextBox rtbDescription;
        private TextBox txbWeight;
        private Label label1;
        private TextBox txbPrice;
        private ComboBox cbOrigin;
        private CheckBox ckbShelve;
        private Button btnChange;
        private TextBox txbStock;
        private Label label2;
    }
}