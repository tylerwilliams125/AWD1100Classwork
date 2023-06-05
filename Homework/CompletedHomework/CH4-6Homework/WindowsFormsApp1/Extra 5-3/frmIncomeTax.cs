using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Extra_5_3
{
    public partial class frmIncomeTax : Form
    {
        public frmIncomeTax()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTaxableIncome.Text = string.Empty;
            txtTaxableIncome.Focus();
            txtIncomeTaxOwed.Text = string.Empty;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            RunTheProgram();


        }

        private void RunTheProgram()
        {
            decimal taxableIncome = 0m;
            
            bool keepGoing = ValidateTaxableIncome(out taxableIncome);

            if (keepGoing)
            {
                CalculateTaxOwed(taxableIncome);
            }
            else
            {
                return;
            }
        }

        private bool ValidateTaxableIncome(out decimal ti)
        {
            bool result;
           

            if (txtTaxableIncome.Text.Trim() == "") 
            {
                ShowMessage("Taxable Income TextBox Cannot Be Empty",
                            "EMPTY TAXABLE INCOME TEXTBOX");
                txtTaxableIncome.Focus();
                ti = 0M;
                return false;
            }
            result = Decimal.TryParse(txtTaxableIncome.Text, out ti);
            if (!result || ti <= 0) 
            {
                ShowMessage("Taxable Income Invalid (Non-Numeric or <=0)",
                            "INVALID TAXABLE INCOME");

                txtTaxableIncome.Text = "";
                txtTaxableIncome.Focus();
                return false;
            }

            
            return true;
            
        }

        private void CalculateTaxOwed(decimal ti)
        {
            decimal taxOwed;

            if (ti > 578125.00m)
            {
                taxOwed = 174238.25m + ((ti - 578125.00m) * 0.37m);
            }

            else if (ti > 231250.00m)
            {
                taxOwed = 52832.00m + ((ti - 231250.00m) * 0.35m);
            }

            else if (ti > 182100.00m)
            {
                taxOwed = 37104.00m + ((ti - 182100.00m) * 0.32m);
            }

            else if (ti > 95375.00m)
            {
                taxOwed = 16290.00m + ((ti - 95375.00m) * 0.24m);

            }

            else if (ti > 44725.00m)
            {
                taxOwed = 5147.00m + ((ti - 44725.00m) * 0.22m);
            }

            else if (ti > 11000.00m)
            {
                taxOwed = 1100.00m + ((ti - 11000.00m) * 0.12m);
            }

            else
            {
                taxOwed = ti * 0.01m;
            }

            txtTaxableIncome.Text = ti.ToString("c");
            txtIncomeTaxOwed.Text = taxOwed.ToString("c");

        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
