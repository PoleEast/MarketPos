namespace MarketPos.FormPage
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            ptbLogo = new PictureBox();
            lbL_Account = new Label();
            lbL_Number = new Label();
            txbL_Account = new TextBox();
            txbL_Number = new TextBox();
            btn_Login = new Button();
            btnL_Register = new Button();
            lbL_Welcome = new Label();
            tbcLogic = new TabControl();
            tbLogin = new TabPage();
            btnForget = new Button();
            tbRegister = new TabPage();
            lbR_Name = new Label();
            txbR_Name = new TextBox();
            btnR_Cancel = new Button();
            btnR_Register = new Button();
            txbR_CheckN = new TextBox();
            lbR_CheckN = new Label();
            lbR_Welcome = new Label();
            lbR_Account = new Label();
            lbR_Number = new Label();
            txbR_Account = new TextBox();
            txbR_Number = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            tbcLogic.SuspendLayout();
            tbLogin.SuspendLayout();
            tbRegister.SuspendLayout();
            SuspendLayout();
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.StoreIcon;
            ptbLogo.Location = new Point(12, 8);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(385, 430);
            ptbLogo.TabIndex = 0;
            ptbLogo.TabStop = false;
            // 
            // lbL_Account
            // 
            lbL_Account.AutoEllipsis = true;
            lbL_Account.AutoSize = true;
            lbL_Account.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold);
            lbL_Account.Location = new Point(11, 123);
            lbL_Account.Name = "lbL_Account";
            lbL_Account.Size = new Size(69, 35);
            lbL_Account.TabIndex = 29;
            lbL_Account.Text = "登入";
            // 
            // lbL_Number
            // 
            lbL_Number.AutoEllipsis = true;
            lbL_Number.AutoSize = true;
            lbL_Number.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold);
            lbL_Number.Location = new Point(11, 175);
            lbL_Number.Name = "lbL_Number";
            lbL_Number.Size = new Size(69, 35);
            lbL_Number.TabIndex = 30;
            lbL_Number.Text = "密碼";
            // 
            // txbL_Account
            // 
            txbL_Account.Font = new Font("Microsoft JhengHei UI", 15.75F);
            txbL_Account.Location = new Point(86, 124);
            txbL_Account.MaxLength = 30;
            txbL_Account.Name = "txbL_Account";
            txbL_Account.Size = new Size(249, 34);
            txbL_Account.TabIndex = 31;
            txbL_Account.KeyPress += txb_KeyPress;
            // 
            // txbL_Number
            // 
            txbL_Number.Font = new Font("Microsoft JhengHei UI", 15.75F);
            txbL_Number.Location = new Point(86, 179);
            txbL_Number.MaxLength = 30;
            txbL_Number.Name = "txbL_Number";
            txbL_Number.Size = new Size(249, 34);
            txbL_Number.TabIndex = 32;
            txbL_Number.KeyPress += txb_KeyPress;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_Login.Location = new Point(266, 233);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(69, 43);
            btn_Login.TabIndex = 33;
            btn_Login.Text = "登入";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btnL_Register
            // 
            btnL_Register.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnL_Register.Location = new Point(181, 233);
            btnL_Register.Name = "btnL_Register";
            btnL_Register.Size = new Size(69, 43);
            btnL_Register.TabIndex = 34;
            btnL_Register.Text = "註冊";
            btnL_Register.UseVisualStyleBackColor = true;
            btnL_Register.Click += button1_Click;
            // 
            // lbL_Welcome
            // 
            lbL_Welcome.AutoEllipsis = true;
            lbL_Welcome.AutoSize = true;
            lbL_Welcome.Font = new Font("Microsoft JhengHei UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbL_Welcome.Location = new Point(22, 31);
            lbL_Welcome.Name = "lbL_Welcome";
            lbL_Welcome.Size = new Size(299, 44);
            lbL_Welcome.TabIndex = 35;
            lbL_Welcome.Text = "您好，請支援輸贏";
            // 
            // tbcLogic
            // 
            tbcLogic.Appearance = TabAppearance.FlatButtons;
            tbcLogic.Controls.Add(tbLogin);
            tbcLogic.Controls.Add(tbRegister);
            tbcLogic.ItemSize = new Size(30, 30);
            tbcLogic.Location = new Point(417, 46);
            tbcLogic.Name = "tbcLogic";
            tbcLogic.SelectedIndex = 0;
            tbcLogic.Size = new Size(360, 392);
            tbcLogic.SizeMode = TabSizeMode.Fixed;
            tbcLogic.TabIndex = 36;
            tbcLogic.TabStop = false;
            // 
            // tbLogin
            // 
            tbLogin.Controls.Add(btnForget);
            tbLogin.Controls.Add(lbL_Welcome);
            tbLogin.Controls.Add(lbL_Account);
            tbLogin.Controls.Add(btnL_Register);
            tbLogin.Controls.Add(lbL_Number);
            tbLogin.Controls.Add(btn_Login);
            tbLogin.Controls.Add(txbL_Account);
            tbLogin.Controls.Add(txbL_Number);
            tbLogin.Location = new Point(4, 34);
            tbLogin.Name = "tbLogin";
            tbLogin.Padding = new Padding(3);
            tbLogin.Size = new Size(352, 354);
            tbLogin.TabIndex = 0;
            tbLogin.Text = "tabPage1";
            tbLogin.UseVisualStyleBackColor = true;
            // 
            // btnForget
            // 
            btnForget.Font = new Font("Microsoft JhengHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnForget.Location = new Point(11, 252);
            btnForget.Name = "btnForget";
            btnForget.Size = new Size(69, 24);
            btnForget.TabIndex = 36;
            btnForget.Text = "忘記密碼";
            btnForget.UseVisualStyleBackColor = true;
            btnForget.Click += btnForget_Click;
            // 
            // tbRegister
            // 
            tbRegister.Controls.Add(lbR_Name);
            tbRegister.Controls.Add(txbR_Name);
            tbRegister.Controls.Add(btnR_Cancel);
            tbRegister.Controls.Add(btnR_Register);
            tbRegister.Controls.Add(txbR_CheckN);
            tbRegister.Controls.Add(lbR_CheckN);
            tbRegister.Controls.Add(lbR_Welcome);
            tbRegister.Controls.Add(lbR_Account);
            tbRegister.Controls.Add(lbR_Number);
            tbRegister.Controls.Add(txbR_Account);
            tbRegister.Controls.Add(txbR_Number);
            tbRegister.Location = new Point(4, 34);
            tbRegister.Name = "tbRegister";
            tbRegister.Padding = new Padding(3);
            tbRegister.Size = new Size(352, 354);
            tbRegister.TabIndex = 1;
            tbRegister.UseVisualStyleBackColor = true;
            // 
            // lbR_Name
            // 
            lbR_Name.AutoEllipsis = true;
            lbR_Name.AutoSize = true;
            lbR_Name.Font = new Font("Microsoft JhengHei UI", 18F);
            lbR_Name.Location = new Point(44, 83);
            lbR_Name.Name = "lbR_Name";
            lbR_Name.Size = new Size(61, 30);
            lbR_Name.TabIndex = 44;
            lbR_Name.Text = "暱稱";
            // 
            // txbR_Name
            // 
            txbR_Name.Font = new Font("Microsoft JhengHei UI", 12F);
            txbR_Name.Location = new Point(119, 79);
            txbR_Name.MaxLength = 30;
            txbR_Name.Name = "txbR_Name";
            txbR_Name.Size = new Size(211, 28);
            txbR_Name.TabIndex = 45;
            // 
            // btnR_Cancel
            // 
            btnR_Cancel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnR_Cancel.Location = new Point(35, 293);
            btnR_Cancel.Name = "btnR_Cancel";
            btnR_Cancel.Size = new Size(69, 43);
            btnR_Cancel.TabIndex = 43;
            btnR_Cancel.Text = "返回";
            btnR_Cancel.UseVisualStyleBackColor = true;
            btnR_Cancel.Click += btnR_Cancel_Click;
            // 
            // btnR_Register
            // 
            btnR_Register.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnR_Register.Location = new Point(261, 293);
            btnR_Register.Name = "btnR_Register";
            btnR_Register.Size = new Size(69, 43);
            btnR_Register.TabIndex = 42;
            btnR_Register.Text = "註冊";
            btnR_Register.UseVisualStyleBackColor = true;
            btnR_Register.Click += btnR_Register_Click;
            // 
            // txbR_CheckN
            // 
            txbR_CheckN.Font = new Font("Microsoft JhengHei UI", 12F);
            txbR_CheckN.Location = new Point(119, 235);
            txbR_CheckN.MaxLength = 30;
            txbR_CheckN.Name = "txbR_CheckN";
            txbR_CheckN.Size = new Size(211, 28);
            txbR_CheckN.TabIndex = 40;
            txbR_CheckN.KeyPress += txb_KeyPress;
            // 
            // lbR_CheckN
            // 
            lbR_CheckN.AutoEllipsis = true;
            lbR_CheckN.AutoSize = true;
            lbR_CheckN.Font = new Font("Microsoft JhengHei UI", 18F);
            lbR_CheckN.Location = new Point(-4, 239);
            lbR_CheckN.Name = "lbR_CheckN";
            lbR_CheckN.Size = new Size(109, 30);
            lbR_CheckN.TabIndex = 38;
            lbR_CheckN.Text = "確認密碼";
            // 
            // lbR_Welcome
            // 
            lbR_Welcome.AutoEllipsis = true;
            lbR_Welcome.AutoSize = true;
            lbR_Welcome.Font = new Font("Microsoft JhengHei UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbR_Welcome.Location = new Point(66, 19);
            lbR_Welcome.Name = "lbR_Welcome";
            lbR_Welcome.Size = new Size(264, 44);
            lbR_Welcome.TabIndex = 37;
            lbR_Welcome.Text = "您好，歡迎加入";
            // 
            // lbR_Account
            // 
            lbR_Account.AutoEllipsis = true;
            lbR_Account.AutoSize = true;
            lbR_Account.Font = new Font("Microsoft JhengHei UI", 18F);
            lbR_Account.Location = new Point(44, 132);
            lbR_Account.Name = "lbR_Account";
            lbR_Account.Size = new Size(61, 30);
            lbR_Account.TabIndex = 33;
            lbR_Account.Text = "帳號";
            // 
            // lbR_Number
            // 
            lbR_Number.AutoEllipsis = true;
            lbR_Number.AutoSize = true;
            lbR_Number.Font = new Font("Microsoft JhengHei UI", 18F);
            lbR_Number.Location = new Point(44, 187);
            lbR_Number.Name = "lbR_Number";
            lbR_Number.Size = new Size(61, 30);
            lbR_Number.TabIndex = 34;
            lbR_Number.Text = "密碼";
            // 
            // txbR_Account
            // 
            txbR_Account.Font = new Font("Microsoft JhengHei UI", 12F);
            txbR_Account.Location = new Point(119, 128);
            txbR_Account.MaxLength = 30;
            txbR_Account.Name = "txbR_Account";
            txbR_Account.Size = new Size(211, 28);
            txbR_Account.TabIndex = 35;
            txbR_Account.KeyPress += txb_KeyPress;
            // 
            // txbR_Number
            // 
            txbR_Number.Font = new Font("Microsoft JhengHei UI", 12F);
            txbR_Number.Location = new Point(119, 183);
            txbR_Number.MaxLength = 30;
            txbR_Number.Name = "txbR_Number";
            txbR_Number.PlaceholderText = "6~20個英文數字";
            txbR_Number.Size = new Size(211, 28);
            txbR_Number.TabIndex = 36;
            txbR_Number.KeyPress += txb_KeyPress;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbcLogic);
            Controls.Add(ptbLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "登入";
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            tbcLogic.ResumeLayout(false);
            tbLogin.ResumeLayout(false);
            tbLogin.PerformLayout();
            tbRegister.ResumeLayout(false);
            tbRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbLogo;
        private Label lbL_Account;
        private Label lbL_Number;
        private TextBox txbL_Account;
        private TextBox txbL_Number;
        private Button btn_Login;
        private Button btnL_Register;
        private Label lbL_Welcome;
        private TabControl tbcLogic;
        private TabPage tbLogin;
        private TabPage tbRegister;
        private Label lbR_CheckN;
        private Label lbR_Welcome;
        private Label lbR_Account;
        private Label lbR_Number;
        private TextBox txbR_Account;
        private TextBox txbR_Number;
        private TextBox txbR_CheckN;
        private Button btnR_Register;
        private Button btnR_Cancel;
        private Label lbR_Name;
        private TextBox txbR_Name;
        private Button btnForget;
    }
}