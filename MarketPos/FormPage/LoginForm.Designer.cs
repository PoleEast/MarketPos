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
            pictureBox1 = new PictureBox();
            lbName = new Label();
            label1 = new Label();
            txbS_Name = new TextBox();
            textBox1 = new TextBox();
            btn_Login = new Button();
            button1 = new Button();
            label2 = new Label();
            tabControl1 = new TabControl();
            tbLogin = new TabPage();
            tbRegister = new TabPage();
            button2 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tbLogin.SuspendLayout();
            tbRegister.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.StoreIcon;
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 430);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoEllipsis = true;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold);
            lbName.Location = new Point(11, 123);
            lbName.Name = "lbName";
            lbName.Size = new Size(69, 35);
            lbName.TabIndex = 29;
            lbName.Text = "登入";
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(11, 175);
            label1.Name = "label1";
            label1.Size = new Size(69, 35);
            label1.TabIndex = 30;
            label1.Text = "密碼";
            // 
            // txbS_Name
            // 
            txbS_Name.Font = new Font("Microsoft JhengHei UI", 15.75F);
            txbS_Name.Location = new Point(86, 124);
            txbS_Name.MaxLength = 30;
            txbS_Name.Name = "txbS_Name";
            txbS_Name.Size = new Size(249, 34);
            txbS_Name.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 15.75F);
            textBox1.Location = new Point(86, 179);
            textBox1.MaxLength = 30;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 34);
            textBox1.TabIndex = 32;
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
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(181, 233);
            button1.Name = "button1";
            button1.Size = new Size(69, 43);
            button1.TabIndex = 34;
            button1.Text = "註冊";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(22, 31);
            label2.Name = "label2";
            label2.Size = new Size(299, 44);
            label2.TabIndex = 35;
            label2.Text = "您好，請支援輸贏";
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tbLogin);
            tabControl1.Controls.Add(tbRegister);
            tabControl1.ItemSize = new Size(30, 30);
            tabControl1.Location = new Point(417, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(360, 392);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 36;
            tabControl1.TabStop = false;
            // 
            // tbLogin
            // 
            tbLogin.Controls.Add(label2);
            tbLogin.Controls.Add(lbName);
            tbLogin.Controls.Add(button1);
            tbLogin.Controls.Add(label1);
            tbLogin.Controls.Add(btn_Login);
            tbLogin.Controls.Add(txbS_Name);
            tbLogin.Controls.Add(textBox1);
            tbLogin.Location = new Point(4, 34);
            tbLogin.Name = "tbLogin";
            tbLogin.Padding = new Padding(3);
            tbLogin.Size = new Size(352, 354);
            tbLogin.TabIndex = 0;
            tbLogin.Text = "tabPage1";
            tbLogin.UseVisualStyleBackColor = true;
            // 
            // tbRegister
            // 
            tbRegister.Controls.Add(button3);
            tbRegister.Controls.Add(button2);
            tbRegister.Controls.Add(textBox5);
            tbRegister.Controls.Add(textBox4);
            tbRegister.Controls.Add(label7);
            tbRegister.Controls.Add(label6);
            tbRegister.Controls.Add(label5);
            tbRegister.Controls.Add(label3);
            tbRegister.Controls.Add(label4);
            tbRegister.Controls.Add(textBox2);
            tbRegister.Controls.Add(textBox3);
            tbRegister.Location = new Point(4, 34);
            tbRegister.Name = "tbRegister";
            tbRegister.Padding = new Padding(3);
            tbRegister.Size = new Size(352, 354);
            tbRegister.TabIndex = 1;
            tbRegister.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(261, 293);
            button2.Name = "button2";
            button2.Size = new Size(69, 43);
            button2.TabIndex = 42;
            button2.Text = "註冊";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft JhengHei UI", 15.75F);
            textBox5.Location = new Point(119, 243);
            textBox5.MaxLength = 30;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 34);
            textBox5.TabIndex = 41;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft JhengHei UI", 15.75F);
            textBox4.Location = new Point(119, 195);
            textBox4.MaxLength = 30;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 34);
            textBox4.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 18F);
            label7.Location = new Point(44, 247);
            label7.Name = "label7";
            label7.Size = new Size(60, 30);
            label7.TabIndex = 39;
            label7.Text = "mail";
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 18F);
            label6.Location = new Point(-4, 199);
            label6.Name = "label6";
            label6.Size = new Size(109, 30);
            label6.TabIndex = 38;
            label6.Text = "確認密碼";
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(66, 19);
            label5.Name = "label5";
            label5.Size = new Size(264, 44);
            label5.TabIndex = 37;
            label5.Text = "您好，歡迎加入";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F);
            label3.Location = new Point(44, 92);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 33;
            label3.Text = "帳號";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 18F);
            label4.Location = new Point(44, 147);
            label4.Name = "label4";
            label4.Size = new Size(61, 30);
            label4.TabIndex = 34;
            label4.Text = "密碼";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft JhengHei UI", 15.75F);
            textBox2.Location = new Point(119, 88);
            textBox2.MaxLength = 30;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 34);
            textBox2.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft JhengHei UI", 15.75F);
            textBox3.Location = new Point(119, 143);
            textBox3.MaxLength = 30;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 34);
            textBox3.TabIndex = 36;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button3.Location = new Point(35, 293);
            button3.Name = "button3";
            button3.Size = new Size(69, 43);
            button3.TabIndex = 43;
            button3.Text = "註冊";
            button3.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "登入";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tbLogin.ResumeLayout(false);
            tbLogin.PerformLayout();
            tbRegister.ResumeLayout(false);
            tbRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbName;
        private Label label1;
        private TextBox txbS_Name;
        private TextBox textBox1;
        private Button btn_Login;
        private Button button1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tbLogin;
        private TabPage tbRegister;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button2;
        private Button button3;
    }
}