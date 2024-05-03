namespace MarketPos
{
    partial class Detail_PCard
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
            ptbProduct = new PictureBox();
            lbOrigin = new Label();
            lbWeight = new Label();
            lbPrice = new Label();
            lbCategory = new Label();
            lbName = new Label();
            btnShoppingCard = new Button();
            rtbDescription = new RichTextBox();
            cbQuantity = new ComboBox();
            lbStock = new Label();
            lbQuantity = new Label();
            lbPerWeight = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbProduct).BeginInit();
            SuspendLayout();
            // 
            // ptbProduct
            // 
            ptbProduct.Location = new Point(12, 12);
            ptbProduct.Name = "ptbProduct";
            ptbProduct.Size = new Size(420, 389);
            ptbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbProduct.TabIndex = 1;
            ptbProduct.TabStop = false;
            // 
            // lbOrigin
            // 
            lbOrigin.AutoEllipsis = true;
            lbOrigin.AutoSize = true;
            lbOrigin.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbOrigin.Location = new Point(446, 78);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new Size(62, 24);
            lbOrigin.TabIndex = 33;
            lbOrigin.Text = "產地 : ";
            // 
            // lbWeight
            // 
            lbWeight.AutoEllipsis = true;
            lbWeight.AutoSize = true;
            lbWeight.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbWeight.Location = new Point(12, 410);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(62, 24);
            lbWeight.TabIndex = 32;
            lbWeight.Text = "重量 : ";
            // 
            // lbPrice
            // 
            lbPrice.AutoEllipsis = true;
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            lbPrice.Location = new Point(432, 403);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(76, 35);
            lbPrice.TabIndex = 31;
            lbPrice.Text = "價格:";
            // 
            // lbCategory
            // 
            lbCategory.AutoEllipsis = true;
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbCategory.Location = new Point(446, 119);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(62, 24);
            lbCategory.TabIndex = 30;
            lbCategory.Text = "種類 : ";
            // 
            // lbName
            // 
            lbName.AutoEllipsis = true;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbName.Location = new Point(438, 26);
            lbName.Name = "lbName";
            lbName.Size = new Size(90, 35);
            lbName.TabIndex = 29;
            lbName.Text = "名稱 : ";
            // 
            // btnShoppingCard
            // 
            btnShoppingCard.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnShoppingCard.Image = Properties.Resources.shopping_cart;
            btnShoppingCard.Location = new Point(713, 366);
            btnShoppingCard.Name = "btnShoppingCard";
            btnShoppingCard.Size = new Size(75, 75);
            btnShoppingCard.TabIndex = 34;
            btnShoppingCard.UseVisualStyleBackColor = true;
            btnShoppingCard.Click += btnS_Search_Click;
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = SystemColors.Control;
            rtbDescription.BorderStyle = BorderStyle.None;
            rtbDescription.Location = new Point(446, 159);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(342, 201);
            rtbDescription.TabIndex = 35;
            rtbDescription.Text = "";
            // 
            // cbQuantity
            // 
            cbQuantity.BackColor = SystemColors.Window;
            cbQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQuantity.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbQuantity.FormattingEnabled = true;
            cbQuantity.Location = new Point(648, 406);
            cbQuantity.Name = "cbQuantity";
            cbQuantity.Size = new Size(50, 32);
            cbQuantity.TabIndex = 36;
            // 
            // lbStock
            // 
            lbStock.AutoEllipsis = true;
            lbStock.AutoSize = true;
            lbStock.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbStock.Location = new Point(615, 119);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(62, 24);
            lbStock.TabIndex = 37;
            lbStock.Text = "庫存 : ";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoEllipsis = true;
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbQuantity.Location = new Point(594, 409);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(52, 24);
            lbQuantity.TabIndex = 38;
            lbQuantity.Text = "數量:";
            // 
            // lbPerWeight
            // 
            lbPerWeight.AutoEllipsis = true;
            lbPerWeight.AutoSize = true;
            lbPerWeight.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbPerWeight.Location = new Point(192, 410);
            lbPerWeight.Name = "lbPerWeight";
            lbPerWeight.Size = new Size(52, 24);
            lbPerWeight.TabIndex = 39;
            lbPerWeight.Text = "每克:";
            // 
            // Detail_PCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbPerWeight);
            Controls.Add(lbQuantity);
            Controls.Add(lbStock);
            Controls.Add(cbQuantity);
            Controls.Add(rtbDescription);
            Controls.Add(btnShoppingCard);
            Controls.Add(lbOrigin);
            Controls.Add(lbWeight);
            Controls.Add(lbPrice);
            Controls.Add(lbCategory);
            Controls.Add(lbName);
            Controls.Add(ptbProduct);
            Name = "Detail_PCard";
            Text = "Detail_PCard";
            Load += Detail_PCard_Load;
            ((System.ComponentModel.ISupportInitialize)ptbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbProduct;
        private Label lbOrigin;
        private Label lbWeight;
        private Label lbPrice;
        private Label lbCategory;
        private Label lbName;
        private Button btnShoppingCard;
        private RichTextBox rtbDescription;
        private ComboBox cbQuantity;
        private Label lbStock;
        private Label lbQuantity;
        private Label lbPerWeight;
    }
}