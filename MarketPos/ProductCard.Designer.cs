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
            ((System.ComponentModel.ISupportInitialize)ptbProduct).BeginInit();
            SuspendLayout();
            // 
            // ptbProduct
            // 
            ptbProduct.Location = new Point(35, 20);
            ptbProduct.Name = "ptbProduct";
            ptbProduct.Size = new Size(160, 160);
            ptbProduct.TabIndex = 0;
            ptbProduct.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(16, 198);
            lbName.Name = "lbName";
            lbName.Size = new Size(42, 15);
            lbName.TabIndex = 2;
            lbName.Text = "label1";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(136, 317);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(42, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "label2";
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(16, 317);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(42, 15);
            lbStock.TabIndex = 4;
            lbStock.Text = "label3";
            // 
            // lbOrigin
            // 
            lbOrigin.AutoSize = true;
            lbOrigin.Location = new Point(16, 274);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new Size(42, 15);
            lbOrigin.TabIndex = 5;
            lbOrigin.Text = "label1";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbOrigin);
            Controls.Add(lbStock);
            Controls.Add(lbPrice);
            Controls.Add(lbName);
            Controls.Add(ptbProduct);
            Name = "ProductCard";
            Size = new Size(230, 345);
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
    }
}
