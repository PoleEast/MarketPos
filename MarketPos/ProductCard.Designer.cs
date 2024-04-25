namespace MarketPos
{
    partial class ProductCard
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            ptbProduct = new PictureBox();
            lbName = new Label();
            lbPrice = new Label();
            lbStock = new Label();
            lbOrigin = new Label();
            lbScore = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbProduct).BeginInit();
            SuspendLayout();
            // 
            // ptbProduct
            // 
            ptbProduct.Location = new Point(35, 20);
            ptbProduct.Name = "ptbProduct";
            ptbProduct.Size = new Size(160, 160);
            ptbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbProduct.TabIndex = 0;
            ptbProduct.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbName.Location = new Point(16, 187);
            lbName.Name = "lbName";
            lbName.Size = new Size(0, 24);
            lbName.TabIndex = 2;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(101, 277);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(34, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "價格:";
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(16, 277);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(34, 15);
            lbStock.TabIndex = 4;
            lbStock.Text = "庫存:";
            // 
            // lbOrigin
            // 
            lbOrigin.AutoSize = true;
            lbOrigin.Location = new Point(16, 225);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new Size(43, 15);
            lbOrigin.TabIndex = 5;
            lbOrigin.Text = "生產地";
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Location = new Point(16, 250);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(34, 15);
            lbScore.TabIndex = 6;
            lbScore.Text = "評分:";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbScore);
            Controls.Add(lbOrigin);
            Controls.Add(lbStock);
            Controls.Add(lbPrice);
            Controls.Add(lbName);
            Controls.Add(ptbProduct);
            Name = "ProductCard";
            Size = new Size(230, 300);
            ((System.ComponentModel.ISupportInitialize)ptbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbProduct;
        private Label lbName;
        private Label lbPrice;
        private Label lbStock;
        private Label lbOrigin;
        private Label lbScore;
    }
}
