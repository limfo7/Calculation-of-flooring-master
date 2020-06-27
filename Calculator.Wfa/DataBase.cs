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
    }
}
