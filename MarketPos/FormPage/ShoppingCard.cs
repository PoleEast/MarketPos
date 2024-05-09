using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketPos
{
    public partial class ShoppingCard : UserControl
    {
        private ProductsData? productsData;
        private bool isShoppingCar;
        public static event EventHandler<KeyValuePair<int, int>>? OrderItemChange;
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
        }

        private void cbCount_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender == null) return;
            if (productsData == null) return;

            KeyValuePair<int, int> orderDetail = new KeyValuePair<int, int>(productsData.Id, cbCount.SelectedIndex + 1);
            OrderItemChange?.Invoke(this, orderDetail);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (sender == null) return;
            if (productsData == null) return;

            OrderItemDelete?.Invoke(this, productsData.Id);
        }
    }
}
