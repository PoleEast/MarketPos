using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using MarketPos.Properties;
using MarketPos.FormPage;

namespace MarketPos
{
    public partial class Form1 : Form
    {
        public static string Imgpath = @"../../../ProductsImg";
        public static Member? member;
        public static List<ProductsData> productsDatas = [];
        private List<ProductCard> productCards = [];
        private int nextOrderNum;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await DataService.P_getProductCardsDatas();

            //�]�w�̷s�q��s�� �榡ex:"yydddoooo"
            string latestOrderNum = (await DataService.Odr_getLatestOrderNum()).ToString();

            nextOrderNum = latestOrderNum.Substring(0, 5) == DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear.ToString("D3") ?
                int.Parse(latestOrderNum) - (int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear.ToString("D3") + "0000")) + 1 : 1;

            //��������Ҧ��d��
            productCards.Add(productCard1);
            productCards.Add(productCard2);
            productCards.Add(productCard3);
            productCards.Add(productCard4);
            productCards.Add(productCard5);
            productCards.Add(productCard6);
            productCards.Add(productCard7);
            productCards.Add(productCard8);

            //UI��l�ƥ�
            cb_Sort.SelectedIndex = 0;
            cb_Sort.SelectedIndexChanged += cb_Sort_SelectedIndexChanged;

            //�Ȯɨϥ�
            productSort("�W��", true);
            Set_Page();
            cb_init();
        }

        /// <summary>
        /// �̷ӭ����ӫ~�ƶq�������ƨ���ܥX��
        /// </summary>
        private void setProductCardsDatas(int page)
        {
            List<ProductsData> currentUI_Cards = [];

            productCards.ForEach(o => o.init());

            //�p��ݭn���Ӱ϶����ӫ~
            int uip_Count = productCards.Count;
            int first = uip_Count * page - uip_Count;
            int last = productsDatas.Count - first < 8 ? productsDatas.Count : first + uip_Count;

            //�N�ӫ~��ܥX��
            for (int i = first; i < last; i++)
                currentUI_Cards.Add(productsDatas[i]);
            foreach (ProductsData product in currentUI_Cards)
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
            DataService.P_insertProduct(productData);
        }

        /// <summary>
        /// true��desc,false��asce
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="mode"></param>
        public void productSort(string condition, bool mode)
        {
            if (condition == "�W��")
                productsDatas.Sort((a, b) => mode ? -string.Compare(a.Name, b.Name) : string.Compare(a.Name, b.Name));
            else if (condition == "����")
                productsDatas.Sort((a, b) => mode ? -a.Category.CompareTo(b.Category) : a.Category.CompareTo(b.Category));
            else if (condition == "����")
                productsDatas.Sort((a, b) => mode ? -a.Price.CompareTo(b.Price) : a.Price.CompareTo(b.Price));
            else if (condition == "���q")
                productsDatas.Sort((a, b) => mode ? -a.Weight.CompareTo(b.Weight) : a.Weight.CompareTo(b.Weight));
            else if (condition == "���a")
                productsDatas.Sort((a, b) => mode ? -a.Origin.CompareTo(b.Origin) : a.Origin.CompareTo(b.Origin));
            else
            {
                MessageBox.Show("�ӫ~�ƧǥX�{���~");
                return;
            }
            //UI�]�w
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

        //�����J���Ʀr
        private void check_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private async void cbAddCategoryType_Click(object sender, EventArgs e)
        {
            UserInputForm userInput = new("�п�J�s�W�����O:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //��J�T�{
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            await DataService.P_AddCategoryType(userInput.userinput);
            cb_init();
        }

        private async void btnAddOriginType_Click(object sender, EventArgs e)
        {
            UserInputForm userInput = new("�п�J�s�W�����a:")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            //��J�T�{
            if (userInput.ShowDialog(this) == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(userInput.userinput)) return;

            //�N�s���O��J��Ʈw
            await DataService.P_AddOriginType(userInput.userinput);
            cb_init();
        }

        private void Set_Page()
        {
            int p_count = productsDatas.Count;

            //�q��page����
            int page = (int)Math.Floor(p_count / 8d);
            if (p_count % 8 != 0) page++;

            cbPage.Items.Clear();
            for (int i = 1; i <= page; i++)
                cbPage.Items.Add(i.ToString());

            //���UI�ƭ�
            if (cbPage.Items.Count != 0) cbPage.SelectedIndex = 0;
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

        //�N��ƶ�Jcb
        private async void cb_init()
        {
            cbAddP_category.Items.Clear();
            cbAddP_origin.Items.Clear();
            cbAddP_stock.Items.Clear();
            cbS_Category.Items.Clear();
            cbS_Origin.Items.Clear();
            await DataService.P_GetCategoryType();
            await DataService.P_GetOriginType();
            for (int i = 0; i < 100; i++)
                cbAddP_stock.Items.Add(i);

            cbAddP_category.Items.AddRange(DataService.categorysDict.Select(o => o.Key).ToArray());
            cbS_Category.Items.AddRange(DataService.categorysDict.Select(o => o.Key).ToArray());
            cbAddP_origin.Items.AddRange(DataService.originsDict.Select(o => o.Key).ToArray());
            cbS_Origin.Items.AddRange(DataService.originsDict.Select(o => o.Key).ToArray());
        }

        private async void btnS_Search_Click(object sender, EventArgs e)
        {
            ProductsData productData = new ProductsData();
            try
            {
                productData.Name = txbS_Name.Text.Trim();
                productData.Category = cbS_Category.Text;
                Decimal.TryParse(txbS_Price.Text.Trim(), out decimal price);
                productData.Price = price;
                double.TryParse(txbS_weight.Text.Trim(), out double weight);
                productData.Weight = weight;
                productData.Origin = cbS_Origin.Text;
            }
            catch (Exception ex) { MessageBox.Show($"��J���~{ex}"); return; }

            await DataService.P_SelectProducts(productData, btnS_PriceToggle.Text == "�H�W", btnS_WeightToggle.Text == "�H�W");
            if (productsDatas.Count == 0) { MessageBox.Show("�d�L�����"); return; }
            if (ptb_Sort.Tag == null)
            {
                MessageBox.Show("�䤣��ptb_Sort.tag");
                return;
            }
            productSort("�W��", ptb_Sort.Tag.ToString() == "descendingOrder");
            Set_Page();
        }

        private void btnS_WeightToggle_Click(object sender, EventArgs e)
        {
            if (btnS_WeightToggle.Text == "�H�W")
                btnS_WeightToggle.Text = "�H�U";
            else if (btnS_WeightToggle.Text == "�H�U")
                btnS_WeightToggle.Text = "�H�W";
        }

        private void btnS_PriceToggle_Click(object sender, EventArgs e)
        {
            if (btnS_PriceToggle.Text == "�H�W")
                btnS_PriceToggle.Text = "�H�U";
            else if (btnS_PriceToggle.Text == "�H�U")
                btnS_PriceToggle.Text = "�H�W";
        }

        private async void btnS_Clear_Click(object sender, EventArgs e)
        {
            txbS_Name.Text = "";
            txbS_Price.Text = "";
            txbS_weight.Text = "";
            cbS_Category.SelectedIndex = -1;
            cbS_Origin.SelectedIndex = -1;
            cb_Sort.SelectedIndex = 0;
            await DataService.P_getProductCardsDatas();
            if (ptb_Sort.Tag == null)
            {
                MessageBox.Show("�䤣��ptb_Sort.tag");
                return;
            }
            productSort("�W��", ptb_Sort.Tag.ToString() == "descendingOrder");
            Set_Page();
        }

        private void cb_Sort_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (ptb_Sort.Tag == null || sender == null) return;
            productSort(cb_Sort.Text, ptb_Sort.Tag.ToString() == "descendingOrder");
            setProductCardsDatas(1);
        }

        private void ptb_Sort_Click(object sender, EventArgs e)
        {
            if (ptb_Sort.Tag == null) return;
            if (ptb_Sort.Tag.ToString() == "descendingOrder")
            {
                ptb_Sort.Image = Resources.ascendingOrder;
                ptb_Sort.Tag = "ascendingOrder";
                productSort(cb_Sort.Text, false);
            }
            else if (ptb_Sort.Tag.ToString() == "ascendingOrder")
            {
                ptb_Sort.Image = Resources.descendingOrder;
                ptb_Sort.Tag = "descendingOrder";
                productSort(cb_Sort.Text, true);
            }
            Set_Page();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (member == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.LoginSuccess += LoginForMem_LoginSuccess;
                loginForm.ShowDialog();
            }
            else
            {
                //�n�X�\��
                member = null;
                btn_Login.Text = "���U/�n�J";
            }
        }
        private void LoginForMem_LoginSuccess(object? sender, Member e)
        {
            if (sender == null) { MessageBox.Show("�n�J��������"); return; }

            if (e.Id == 0) { MessageBox.Show("�d�L���Τ�W��"); return; };
            member = e;
            lbMember.Text = $"�w��^��: {member.Name}";
            if (sender is LoginForm loginForm)
                loginForm.LoginSuccess -= LoginForMem_LoginSuccess;
            btn_Login.Text = "�n�X";
            getShoppingOrderID();
        }

        private async void getShoppingOrderID()
        {
            if (member == null) return;
            int orderid = await DataService.Odr_GetMemberShopping(member.Id);
            if (orderid == 0)
            {
                await DataService.Odr_CreateNewShopping(Odr_getLatestOrderNum(), member.Id);
                orderid = await DataService.Odr_GetMemberShopping(member.Id);
            }
            member.OrderId = orderid;
        }

        private void btntest_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(cbPage.Text + "\n" + cbPage.SelectedIndex);
        }
        private int Odr_getLatestOrderNum()
        {
            return int.Parse(DateTime.Now.ToString("yy") + DateTime.Now.DayOfYear.ToString("D3") + nextOrderNum.ToString("0000"));
        }
    }
}

