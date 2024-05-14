using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketPos.Models;

namespace MarketPos
{
    public partial class ShoppingCard : UserControl
    {
        private ProductsData? productsData;
        private bool isShoppingCar;
        public static event EventHandler<OrderDetail>? OrderItemChange;
        public static event EventHandler<int>? OrderItemDelete;
        public int total;

        /// <param name="isShoppingCar">
        /// false會將更改數量功能關閉
        /// </param>
        public ShoppingCard(bool isShoppingCar)
        {
            InitializeComponent();
            this.isShoppingCar = isShoppingCar;
        }
        public void SetCard(ProductsData data, int quantity)
        {
            productsData = data;
            lbName.Text = data.Name;
            lbPrice.Text += data.Price.ToString() + "$";

            //設定是否要啟用更改數量功能
            for (int i = 1; i <= data.Stock; i++)
                cbCount.Items.Add(i);
            cbCount.SelectedIndex = quantity - 1;
            if (isShoppingCar)
            {
                cbCount.SelectedIndexChanged += cbCount_SelectedIndexChanged;
                cbCount.Enabled = true;
            }

            txbTotal.Text += (data.Price * quantity) + "$";
            total = Convert.ToInt16(data.Price * quantity);

            //開啟管理者訂單確認功能
            if (Form1.member.Level > 2) return;

            btnDelete.Enabled = false;
            btnDelete.Visible = false;

            CheckBox ckbConfirmed = new CheckBox();
            ckbConfirmed.Text = "商品訂單確認";
            ckbConfirmed.Location = btnDelete.Location; // 設置按鈕位置
            ckbConfirmed.Size = btnDelete.Size;
            ckbConfirmed.Font = btnDelete.Font;
            ckbConfirmed.
            ckbConfirmed.CheckedChanged += ckbConfirmed_CheckedChanged; // 設置按鈕點擊事件處理程序
            this.Controls.Add(ckbConfirmed);
        }

        private void cbCount_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender == null) return;
            if (productsData == null) return;

            OrderDetail orderDetail = new OrderDetail();
            orderDetail.productID=productsData.Id;
            orderDetail.quantity = cbCount.SelectedIndex + 1;
            OrderItemChange?.Invoke(this, orderDetail);
        }

        private void ckbConfirmed_CheckedChanged(object? sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (sender == null) return;
            if (productsData == null) return;

            OrderItemDelete?.Invoke(this, productsData.Id);
        }

        private void shoppingCard_Click(object sender, EventArgs e)
        {
            if (productsData == null) return;
            Detail_PCard detail_PCard = new(productsData);
            detail_PCard.StartPosition = FormStartPosition.CenterParent;
            detail_PCard.ShowDialog();
        }
    }
}
