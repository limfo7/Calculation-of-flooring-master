using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator.Wfa
{
    public partial class DataBase : Form
    {
        public Model1 AppContext { get; set; }

        public DataBase()
        {
            InitializeComponent();
            AppContext = new Model1();
            RefreshManufacturers();
            RefreshCoverageTypes();
        }

        private void ShowManufacturersBtn_Click(object sender, EventArgs e)
        {
            ManufacturersDataGridView.DataSource = AppContext.Manufacturers.ToList();
        }

        private void ShowProductsBtn_Click(object sender, EventArgs e)
        {
            var covType = AppContext.CoverageTypes.ToList();
            var manufacturer = AppContext.Manufacturers.ToList();
            var products = AppContext.Products.ToList();
            ProductDataGridView.DataSource = products
                .Join(
                covType,
                prod => prod.CoverageTypeId,
                cov => cov.CoverageTypeId,
                (prod, cov) => new
                {
                    ProductId = prod.ProductId,
                    Name = prod.Name,
                    CoverageName = cov.Name,
                    ManufacturerId = prod.ManufacturerId,
                    Cost1 = prod.Coast1,
                    CostOpt = prod.CoastOpt
                })
                .Join(
                manufacturer,
                prod => prod.ManufacturerId,
                man => man.ManufacturerId,
                (prod, man) => new
                {
                    ProductId = prod.ProductId,
                    Name = prod.Name,
                    CoverageName = prod.CoverageName,
                    ManufacturerName = man.Name,
                    Cost1 = prod.Cost1,
                    CostOpt = prod.CostOpt
                })
                .Select(item
                => new
                {
                    Id = item.ProductId,
                    ТипПокрытия = item.CoverageName,
                    Производитель = item.ManufacturerName,
                    Продукт = item.Name,
                    Цена1 = item.Cost1,
                    ЦенаОпт = item.CostOpt
                }).ToList();
        }

        private void ShowOrdersBtn_Click(object sender, EventArgs e)
        {
            OrdersDataGridView.DataSource = AppContext.OrderforBuyings.ToList();
        }


        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            var prodId = AppContext.Products.Count();
            MessageBox.Show("New product is added");
            if (NameTextBox.Text != string.Empty ||
                Cost1TextBox.Text != string.Empty ||
                CostOptTextBox.Text != string.Empty)
            {
                AppContext.Products.Add(
                    new Product
                    {
                        ProductId=prodId,
                        Coast1 = Convert.ToDouble(Cost1TextBox.Text),
                        CoastOpt = Convert.ToDouble(CostOptTextBox.Text),
                        Name = NameTextBox.Text,
                        ManufacturerId = ManufacturerComboBox.SelectedIndex+1,
                        CoverageTypeId = CoverageTypeComboBox.SelectedIndex+1
                    });
            }
            AppContext.SaveChanges();
        }

        public void RefreshManufacturers()
        {
            ManufacturerComboBox.Items.Clear();
            var manufacturers = AppContext.Manufacturers.ToList();
            object[] items = new object[manufacturers.Count];
            var i = 0;
            foreach (var item in manufacturers)
            {
                items[i++] = $"{i}. {item.Name}";
            }
            ManufacturerComboBox.Items.AddRange(items);
        }

        public void RefreshCoverageTypes()
        {
            CoverageTypeComboBox.Items.Clear();
            var coverageTypes = AppContext.CoverageTypes.ToList();
            object[] items = new object[coverageTypes.Count];
            var i = 0;
            foreach (var item in coverageTypes)
            {
                items[i++] = $"{i}. {item.Name}";
            }
            CoverageTypeComboBox.Items.AddRange(items);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var orderId = AppContext.OrderforBuyings.Count();
            MessageBox.Show("Продукт добавлен");
            if (textBox1.Text!=string.Empty && textBox2.Text!=string.Empty)
            {
                AppContext.OrderforBuyings.Add(
                    new OrderforBuying
                    {
                        OrderId = orderId,
                        OrderNumber = textBox2.Text,
                        ProductId = Convert.ToInt32(textBox1.Text)
                    }
                    );
                AppContext.SaveChanges();
            }
        }
    }
}
