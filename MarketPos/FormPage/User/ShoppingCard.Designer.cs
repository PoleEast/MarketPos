namespace MarketPos
{
    partial class ShoppingCard
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
            lbName = new Label();
            lbCount = new Label();
            btnDelete = new Button();
            txbTotal = new TextBox();
            lbPrice = new Label();
            cbCount = new ComboBox();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoEllipsis = true;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbName.Location = new Point(3, 9);
            lbName.Name = "lbName";
            lbName.Size = new Size(54, 26);
            lbName.TabIndex = 28;
            lbName.Text = "名稱";
            lbName.Click += shoppingCard_Click;
            // 
            // lbCount
            // 
            lbCount.AutoEllipsis = true;
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbCount.Location = new Point(301, 6);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(48, 24);
            lbCount.TabIndex = 31;
            lbCount.Text = "數量";
            lbCount.Click += shoppingCard_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(3, 63);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txbTotal
            // 
            txbTotal.BackColor = SystemColors.Menu;
            txbTotal.BorderStyle = BorderStyle.None;
            txbTotal.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            txbTotal.Location = new Point(198, 60);
            txbTotal.Name = "txbTotal";
            txbTotal.Size = new Size(207, 25);
            txbTotal.TabIndex = 33;
            txbTotal.Text = "金額:";
            txbTotal.TextAlign = HorizontalAlignment.Right;
            txbTotal.Click += shoppingCard_Click;
            // 
            // lbPrice
            // 
            lbPrice.AutoEllipsis = true;
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbPrice.Location = new Point(84, 64);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(42, 19);
            lbPrice.TabIndex = 34;
            lbPrice.Text = "單價:";
            lbPrice.Click += shoppingCard_Click;
            // 
            // cbCount
            // 
            cbCount.BackColor = SystemColors.Window;
            cbCount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCount.Enabled = false;
            cbCount.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbCount.ForeColor = SystemColors.WindowText;
            cbCount.FormattingEnabled = true;
            cbCount.Location = new Point(355, 3);
            cbCount.Name = "cbCount";
            cbCount.Size = new Size(50, 32);
            cbCount.TabIndex = 30;
            // 
            // ShoppingCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbPrice);
            Controls.Add(txbTotal);
            Controls.Add(btnDelete);
            Controls.Add(lbCount);
            Controls.Add(cbCount);
            Controls.Add(lbName);
            Cursor = Cursors.Hand;
            Name = "ShoppingCard";
            Size = new Size(416, 89);
            Click += shoppingCard_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbCount;
        private Button btnDelete;
        private TextBox txbTotal;
        private Label lbPrice;
        private ComboBox cbCount;
    }
}
