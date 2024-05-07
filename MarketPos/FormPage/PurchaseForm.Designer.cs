namespace MarketPos.FormPage
{
    partial class PurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            lbR_Name = new Label();
            lbR_Address = new Label();
            lb_PayMent = new Label();
            txbR_Name = new TextBox();
            txbR_Address = new TextBox();
            cb_PayMent = new ComboBox();
            txbO_Address = new TextBox();
            txbO_Name = new TextBox();
            lbO_Address = new Label();
            lbO_Name = new Label();
            lb_OrderNum = new Label();
            ptb_Icon = new PictureBox();
            btn_OK = new Button();
            ((System.ComponentModel.ISupportInitialize)ptb_Icon).BeginInit();
            SuspendLayout();
            // 
            // lbR_Name
            // 
            lbR_Name.AutoEllipsis = true;
            lbR_Name.AutoSize = true;
            lbR_Name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbR_Name.Location = new Point(44, 215);
            lbR_Name.Name = "lbR_Name";
            lbR_Name.Size = new Size(109, 24);
            lbR_Name.TabIndex = 2;
            lbR_Name.Text = "收貨人名稱:";
            // 
            // lbR_Address
            // 
            lbR_Address.AutoEllipsis = true;
            lbR_Address.AutoSize = true;
            lbR_Address.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbR_Address.Location = new Point(44, 260);
            lbR_Address.Name = "lbR_Address";
            lbR_Address.Size = new Size(105, 24);
            lbR_Address.TabIndex = 3;
            lbR_Address.Text = "收貨人地址";
            // 
            // lb_PayMent
            // 
            lb_PayMent.AutoEllipsis = true;
            lb_PayMent.AutoSize = true;
            lb_PayMent.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lb_PayMent.Location = new Point(44, 306);
            lb_PayMent.Name = "lb_PayMent";
            lb_PayMent.Size = new Size(86, 24);
            lb_PayMent.TabIndex = 4;
            lb_PayMent.Text = "付款方式";
            // 
            // txbR_Name
            // 
            txbR_Name.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbR_Name.Location = new Point(159, 215);
            txbR_Name.MaxLength = 20;
            txbR_Name.Name = "txbR_Name";
            txbR_Name.Size = new Size(205, 28);
            txbR_Name.TabIndex = 10;
            // 
            // txbR_Address
            // 
            txbR_Address.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbR_Address.Location = new Point(159, 260);
            txbR_Address.MaxLength = 50;
            txbR_Address.Name = "txbR_Address";
            txbR_Address.Size = new Size(398, 28);
            txbR_Address.TabIndex = 11;
            // 
            // cb_PayMent
            // 
            cb_PayMent.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_PayMent.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cb_PayMent.FormattingEnabled = true;
            cb_PayMent.Location = new Point(136, 302);
            cb_PayMent.Name = "cb_PayMent";
            cb_PayMent.Size = new Size(170, 28);
            cb_PayMent.TabIndex = 29;
            // 
            // txbO_Address
            // 
            txbO_Address.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbO_Address.Location = new Point(159, 144);
            txbO_Address.MaxLength = 50;
            txbO_Address.Name = "txbO_Address";
            txbO_Address.Size = new Size(398, 28);
            txbO_Address.TabIndex = 33;
            // 
            // txbO_Name
            // 
            txbO_Name.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbO_Name.Location = new Point(159, 99);
            txbO_Name.MaxLength = 20;
            txbO_Name.Name = "txbO_Name";
            txbO_Name.Size = new Size(205, 28);
            txbO_Name.TabIndex = 32;
            // 
            // lbO_Address
            // 
            lbO_Address.AutoEllipsis = true;
            lbO_Address.AutoSize = true;
            lbO_Address.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbO_Address.Location = new Point(44, 144);
            lbO_Address.Name = "lbO_Address";
            lbO_Address.Size = new Size(105, 24);
            lbO_Address.TabIndex = 31;
            lbO_Address.Text = "收貨人地址";
            // 
            // lbO_Name
            // 
            lbO_Name.AutoEllipsis = true;
            lbO_Name.AutoSize = true;
            lbO_Name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbO_Name.Location = new Point(44, 99);
            lbO_Name.Name = "lbO_Name";
            lbO_Name.Size = new Size(109, 24);
            lbO_Name.TabIndex = 30;
            lbO_Name.Text = "收貨人名稱:";
            // 
            // lb_OrderNum
            // 
            lb_OrderNum.AutoEllipsis = true;
            lb_OrderNum.AutoSize = true;
            lb_OrderNum.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lb_OrderNum.Location = new Point(44, 37);
            lb_OrderNum.Name = "lb_OrderNum";
            lb_OrderNum.Size = new Size(115, 30);
            lb_OrderNum.TabIndex = 34;
            lb_OrderNum.Text = "訂單編號:";
            // 
            // ptb_Icon
            // 
            ptb_Icon.Image = Properties.Resources.order;
            ptb_Icon.Location = new Point(454, 6);
            ptb_Icon.Name = "ptb_Icon";
            ptb_Icon.Size = new Size(150, 132);
            ptb_Icon.TabIndex = 35;
            ptb_Icon.TabStop = false;
            // 
            // btn_OK
            // 
            btn_OK.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_OK.Location = new Point(508, 337);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(96, 43);
            btn_OK.TabIndex = 36;
            btn_OK.Text = "確認";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 392);
            Controls.Add(btn_OK);
            Controls.Add(ptb_Icon);
            Controls.Add(lb_OrderNum);
            Controls.Add(txbO_Address);
            Controls.Add(lbO_Address);
            Controls.Add(lbO_Name);
            Controls.Add(cb_PayMent);
            Controls.Add(txbR_Address);
            Controls.Add(txbR_Name);
            Controls.Add(lb_PayMent);
            Controls.Add(lbR_Address);
            Controls.Add(lbR_Name);
            Controls.Add(txbO_Name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PurchaseForm";
            Text = "PurchaseForm";
            ((System.ComponentModel.ISupportInitialize)ptb_Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbR_Name;
        private Label lbR_Address;
        private Label lb_PayMent;
        private TextBox txbR_Name;
        private TextBox txbR_Address;
        private ComboBox cb_PayMent;
        private TextBox txbO_Address;
        private TextBox txbO_Name;
        private Label lbO_Address;
        private Label lbO_Name;
        private Label lb_OrderNum;
        private PictureBox ptb_Icon;
        private Button btn_OK;
    }
}