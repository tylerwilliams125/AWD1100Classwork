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

namespace EX1
{
    public partial class frmHOTGUIArray : Form
    {
        string[] firstName = { "Markel", "Luiza", "Byrony", "Giraldo", "Lowri" };

        string[] lastName = { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };

        decimal[] salaries = { 54321.00m, 88732.00m, 66778.00m, 33445.00m, 99883.00m };
        public frmHOTGUIArray()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            string nameSearch = txtSearch.Text;

            for (int i = 0; i < firstName.Length; i++)
            {
                if (firstName[i].ToLower().Contains(nameSearch.ToLower()))
                {
                    txtFirst.Text = firstName[i];
                    txtLast.Text = lastName[i];
                    txtSalary.Text = Convert.ToString(salaries[i]);
                    break;
                }

     
                else
                {
                    txtFirst.Text = "Person Not Found";
                    txtLast.Text = "Person Not Found";
                   txtSalary.Text = "Salary Not Found";
                }

            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            string nameSearch = txtSearch.Text;

            for (int i = 0; i < lastName.Length; i++)
            {
                if (lastName[i].ToLower().Contains(nameSearch.ToLower()))
                {
                    txtFirst.Text = firstName[i];
                    txtLast.Text = lastName[i];
                    txtSalary.Text = Convert.ToString(salaries[i]);
                    break;
                }


                else
                {
                    txtFirst.Text = "Person Not Found";
                    txtLast.Text = "Person Not Found";
                    txtSalary.Text = "Salary Not Found";
                }

            }

        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
           
            string searchResult = txtSearch.Text;
            decimal salarySearch = decimal.Parse(searchResult);

            for (int i = 0; i < salaries.Length; i++)
            {
                if (salaries[i] == salarySearch)
                {
                    txtFirst.Text = firstName[i];
                    txtLast.Text = lastName[i];
                    txtSalary.Text = Convert.ToString(salaries[i]);
                    break;
                }


                else
                {
                    txtFirst.Text = "Person Not Found";
                    txtLast.Text = "Person Not Found";
                    txtSalary.Text = "Salary Not Found";
                }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            DialogResult dialog = MessageBox.Show(
            "Do You Really Want To Exit The Program?", "EXIT NOW?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
