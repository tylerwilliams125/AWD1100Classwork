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
            CalculateFactorial();

        }

        private void CalculateFactorial()
        {
            bool result = false;
            bool retVal = true;
            int score = 0;

            if (txtNumber.Text.Trim() == "")
            {
                ShowMessage("Number Text Box Cannot Be Empty",
                    "NOTHING INPUTTED FOR NUMBER");
                txtNumber.Focus();

                return;
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
