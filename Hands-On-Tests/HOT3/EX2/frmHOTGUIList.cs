using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class frmHOTGUIList : Form
    {
        List<string> firstNames = new List<string>() { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri" };
        List<string> lastNames = new List<string>() { "Diggory", "Gunnar", "Hester", "Addy", "Hary" };
        List<decimal> salaries = new List<decimal>() { 54321.00m, 88732.00m, 66778.00m, 33445.00m, 99883.00m };

        public frmHOTGUIList()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                string nameSearch = txtSearch.Text;

                bool found = false;

                for (int i = 0; i < firstNames.Count; i++)
                {

                    if (firstNames[i].ToLower().Contains(nameSearch.ToLower()))
                    {
                        txtFirst.Text = firstNames[i];
                        txtLast.Text = lastNames[i];
                        txtSalary.Text = Convert.ToString(salaries[i]);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Not found");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid Format {ex.Message}");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {


            try
            {
                string nameSearch = txtSearch.Text;
  
                bool found = false;

                for (int i = 0; i < lastNames.Count; i++)
                {

                    if (lastNames[i].ToLower().Contains(nameSearch.ToLower()))
                    {
                        txtFirst.Text = firstNames[i];
                        txtLast.Text = lastNames[i];
                        txtSalary.Text = Convert.ToString(salaries[i]);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Not found");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid Format {ex.Message}");
            }


        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
           
            try
            {
                string searchResult = txtSearch.Text;
                decimal salarySearch = decimal.Parse(searchResult);


                bool found = false;

                for (int i = 0; i < salaries.Count; i++)
                {
                    decimal salary = salaries[i];

                    if (salaries[i] == salarySearch)
                    {
                        txtFirst.Text = firstNames[i];
                        txtLast.Text = lastNames[i];
                        txtSalary.Text = Convert.ToString(salaries[i]);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Not found");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid Format {ex.Message}");
            }
            
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
            txtSearch.Text = string.Empty;
            txtFirst.Text = string.Empty;
            txtLast.Text = string.Empty;
            txtSalary.Text = string.Empty;

            txtSearch.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}