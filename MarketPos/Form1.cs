using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketPos
{
    public partial class Form1 : Form
    {
        public static string Imgpath = @"../../../ProductsImg";
        private List<ProductCard> productCards = [];
        private List<ProductsData> productsDatas = [];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //��������Ҧ��d��
            productCards.Add(productCard1);
            productCards.Add(productCard2);
            productCards.Add(productCard3);
            productCards.Add(productCard4);
            productCards.Add(productCard5);
            productCards.Add(productCard6);
            productCards.Add(productCard7);
            productCards.Add(productCard8);

            setProductCardsDatas(1);

            //�Ȯɨϥ�
            Set_Page();
        }

        private void setcbPage()
        {

        }

        /// <summary>
        /// �̷ӭ����ӫ~�ƶq�������ƨ���ܥX��
        /// </summary>
        private async void setProductCardsDatas(int page)
        {
            int uip_Count = productsDatas.Count;
            int first = uip_Count * page - uip_Count;
            productCards.ForEach(o => o.init());
            List<ProductsData> products = await DataService.DS_getProductCardsDatas(first, uip_Count);
            foreach (ProductsData product in products)
            {
                setProductCardsData(product);
            }
        }

        /// <summary>
        /// �N��ƶ�J�٪ůʪ��d��
        /// </summary>
        private void setProductCardsData(ProductsData productsData)
        {
            var productCard = productCards.FirstOrDefault(o => o.Visible == false);
            productCard?.SetCard(productsData);
        }

        private void insertProduct()
        {
            ProductsData productData = new ProductsData
            {
                Name = txbAddP_name.Text.Trim(),
                Weight = Double.Parse(txbAddP_weight.Text.Trim()),
                Price = Decimal.Parse(txbAddP_price.Text.Trim()),
                Category = cbAddP_category.Text.Trim(),
                Description = rtbAddP_description.Text,
                Stock = cbAddP_stock.SelectedIndex,
                Origin = cbAddP_origin.Text
            };
            DataService.DS_insertProduct(productData);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //�T�{�ϥΪ̦��L��J�ƭ�
            if (string.IsNullOrEmpty(txbAddP_name.Text) ||
                string.IsNullOrEmpty(txbAddP_price.Text) ||
                string.IsNullOrEmpty(txbAddP_weight.Text))
            { MessageBox.Show("�п�J���T�����榡"); return; }

            //�T�{�ϥΪ̦��L��ܼƭ�
            if (cbAddP_origin.SelectedIndex == -1 ||
                cbAddP_stock.SelectedIndex == -1 ||
                cbAddP_category.SelectedIndex == -1)
            { MessageBox.Show("�п�ܥ��T�����"); return; }

            //�ϥΪ̽T�{���
            DialogResult result = MessageBox.Show($"�T�{�n�W�[�ӫ~:\n�W��:{txbAddP_name.Text}\n����:{cbAddP_category.Text}\n" +
                $"����:{txbAddP_price.Text}\n���q:{txbAddP_weight.Text}\n���a:{cbAddP_origin.Text}\n" +
                $"�w�s:{cbAddP_stock.Text}", "�T�{", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;

            insertProduct();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
        }


        private void txbAddP_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbAddCategoryType_Click(object sender, EventArgs e)
        {
            UserInput userInput = new("�п�J�s�W�����O:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //��J�T�{
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            DataService.DS_AddCategoryType(userInput.userinput);

        }

        private void btnAddOriginType_Click(object sender, EventArgs e)
        {
            UserInput userInput = new("�п�J�s�W�����a:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //��J�T�{
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            //�N�s���O��J��Ʈw
            DataService.DS_AddOriginType(userInput.userinput);
        }

        private async void Set_Page()
        {
            int p_count = await DataService.DS_GetProductCount("");

            //�q��page����
            int page = (int)Math.Floor(p_count / 8d);
            if (p_count % 8 != 0) page++;

            cbPage.Items.Clear();
            for (int i = 1; i <= page; i++)
                cbPage.Items.Add(i.ToString());

            //���UI�ƭ�
            cbPage.SelectedIndex = 0;
            lbPage.Text = $"/{page}��";
        }

        private void cbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProductCardsDatas(cbPage.SelectedIndex + 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (cbPage.SelectedIndex != cbPage.Items.Count - 1)
                cbPage.SelectedIndex++;
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            if (cbPage.SelectedIndex != 0)
                cbPage.SelectedIndex--;
        }

        //�@�@��l�ƥΪ�
        private void cbAddP_stock_HandleCreated(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                cbAddP_stock.Items.Add(i);
        }
        private void cbAddP_category_HandleCreated(object sender, EventArgs e)
        {
            DataService.DS_GetCategoryType();
            cbAddP_category.Items.AddRange(DataService.categorysDict.Select(o => o.Key).ToArray());
        }
        private void cbAddP_origin_HandleCreated(object sender, EventArgs e)
        {
            DataService.DS_GetOriginType();
            cbAddP_origin.Items.AddRange(DataService.originsDict.Select(o => o.Key).ToArray());
        }
    }
}
