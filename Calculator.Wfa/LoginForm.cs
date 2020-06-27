using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Wfa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordTB.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (LoginTB.Text=="Manager" && PasswordTB.Text == "Password")
            {
                MessageBox.Show("Log In Success");
                CalculatorForm calculatorForm = new CalculatorForm();
                calculatorForm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Log In Failed");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
