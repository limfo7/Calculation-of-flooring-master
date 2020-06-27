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
            ProductDataGridView.DataSource = AppContext.Products.ToList();
        }

        private void ShowOrdersBtn_Click(object sender, EventArgs e)
        {
            OrdersDataGridView.DataSource = AppContext.OrderforBuyings.ToList();
        }


        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != string.Empty ||
                Cost1TextBox.Text != string.Empty ||
                CostOptTextBox.Text != string.Empty)
            {
                AppContext.Products.Add(
                    new Product
                    {
                        Coast1 = Convert.ToDouble(Cost1TextBox.Text),
                        CoastOpt = Convert.ToDouble(CostOptTextBox.Text),
                        Name = NameTextBox.Text,
                        ManufacturerId = ManufacturerComboBox.SelectedIndex,
                        CoverageTypeId = CoverageTypeComboBox.SelectedIndex
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
    }
}
