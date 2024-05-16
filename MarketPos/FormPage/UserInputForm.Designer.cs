namespace MarketPos
{
    partial class UserInputForm
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
            lbExplain = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            txbUserInput = new TextBox();
            SuspendLayout();
            // 
            // lbExplain
            // 
            lbExplain.AutoSize = true;
            lbExplain.Font = new Font("Microsoft JhengHei UI", 12F);
            lbExplain.Location = new Point(27, 9);
            lbExplain.Name = "lbExplain";
            lbExplain.Size = new Size(54, 20);
            lbExplain.TabIndex = 0;
            lbExplain.Text = "label1";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(192, 105);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(60, 28);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(262, 105);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(60, 28);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txbUserInput
            // 
            txbUserInput.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbUserInput.Location = new Point(27, 47);
            txbUserInput.Name = "txbUserInput";
            txbUserInput.Size = new Size(295, 28);
            txbUserInput.TabIndex = 4;
            // 
            // UserInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 144);
            Controls.Add(txbUserInput);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lbExplain);
            Name = "UserInputForm";
            Text = "請輸入文字";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbExplain;
        private Button btnOk;
        private Button btnCancel;
        private TextBox txbUserInput;
    }
}