﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Konscious.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;
using MarketPos.Models;

namespace MarketPos.FormPage
{
    public partial class LoginForm : Form
    {
        public event EventHandler<Member>? LoginSuccess;
        public LoginForm()
        {
            InitializeComponent();
            tbcLogic.ItemSize = new System.Drawing.Size(0, 1);
        }

        private async void btnR_Register_Click(object sender, EventArgs e)
        {
            string name = txbR_Name.Text.Trim();
            string account = txbR_Account.Text.Trim();
            string password = txbR_Number.Text.Trim();
            string check = txbR_CheckN.Text.Trim();
            List<string> list = [name, account, password, check];

            if (list.Any(string.IsNullOrEmpty)) { MessageBox.Show("請輸入帳號密碼"); return; }
            if (!password.Equals(check)) { MessageBox.Show("密碼輸入不一致"); return; }
            if (password.Length < 6) { MessageBox.Show("請輸入正確的密碼格式"); return; }

            //密碼加密
            byte[] salt = Form1.CreateSalt();
            string saltStr = Convert.ToBase64String(salt);
            byte[] hashpassword = Form1.GHashPassword(password, salt);
            string hashpasswordStr = Convert.ToBase64String(hashpassword);

            await DataService.Mem_CreatetMemberName(hashpasswordStr, saltStr, name, account, 3);
            tbcLogic.SelectedIndex = 0;
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            string account = txbL_Account.Text.Trim();
            string password = txbL_Number.Text.Trim();

            if (string.IsNullOrEmpty(account)) { MessageBox.Show("請輸入帳號密碼"); return; }
            if (string.IsNullOrEmpty(password)) { MessageBox.Show("請輸入帳號密碼"); return; }

            //密碼處理
            string saltStr = await DataService.Mem_LoginGetSalt(account);
            if (string.IsNullOrEmpty(saltStr)) { MessageBox.Show("密碼或帳號錯誤"); return; }
            byte[] salt = Convert.FromBase64String(saltStr);
            var hashPassword = Form1.GHashPassword(password, salt);
            string hashpasswordStr = Convert.ToBase64String(hashPassword);

            //驗證帳號密碼
            var checkMember = await DataService.Mem_Login(account, hashpasswordStr);
            if (checkMember.Id == 0) { MessageBox.Show("密碼或帳號錯誤"); return; }

            if (checkMember.Account.Equals(account))
            {
                MessageBox.Show("登入成功!!");
                LoginSuccess?.Invoke(this, checkMember);
                this.Close();
            }
        }
        private void btnForget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("請與客服聯絡\n聯絡方式:客服忙線中");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbcLogic.SelectedIndex = 1;
        }

        private void btnR_Cancel_Click(object sender, EventArgs e)
        {
            tbcLogic.SelectedIndex = 0;
        }

        private void txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (char.IsControl(e.KeyChar)))
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}
