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
                CalculatorForm calculatorForm = new CalculatorForm("Manager");
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

        private void LoginGuestBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log In As Guest Success");
            CalculatorForm calculatorForm = new CalculatorForm("User");
            calculatorForm.Show();
            this.Visible = false;
        }
    }
}
