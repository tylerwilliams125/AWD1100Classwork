using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialNumber
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        const int MINNUMBER = 1;
        const int MAXNUMBER = 20;


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
              "Do You Really Want To Exit The Program?", "EXIT NOW?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           ValidateNumberTextBox();

        }

        private void ValidateNumberTextBox()
        {
            bool result;
            int number;
          

            if (txtNumber.Text.Trim() == "")
            {
                ShowMessage("Number Text Box Cannot Be Empty",
                    "NOTHING INPUTTED FOR NUMBER");
                txtNumber.Focus();

                return;
            }

            result = Int32.TryParse(txtNumber.Text, out number);
            if (!result || (number < MINNUMBER) ||(number > MAXNUMBER))
            {
                ShowMessage("Number must be a number (0-20)",
                    "INVALID INPUT IN TEXTBOX");
                txtNumber.Text = "";
                txtNumber.Focus();
                return;
            }

            CalculateFactorial(number);


        }

        private void CalculateFactorial(int n)
        {
            long factorial = 1;

            while(n != 1)
            {
                factorial*= n;
                n-= 1;
            }

            txtFactorial.Text = factorial.ToString("n0");
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
