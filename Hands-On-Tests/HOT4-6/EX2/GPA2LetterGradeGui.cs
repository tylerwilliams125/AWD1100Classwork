using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class GPA2LetterGradeGui : Form
    {
        public GPA2LetterGradeGui()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           decimal gpa = Convert.ToDecimal(txtGpa.Text);
            if (gpa > 3.2m && gpa <= 4.0m)
            {
                lblGrade.Text = "Your Grade is : A";
            }
            if (gpa > 2.5m && gpa <= 3.2m)
            {
               lblGrade.Text = "Your Grade is : B";
            }
            if (gpa > 1.5m && gpa <= 2.5m)
            {
                lblGrade.Text = "Your Grade is : C";
            }
            if (gpa > 0.0m && gpa <= 1.0m)
            {
                lblGrade.Text = "Your Grade is : D";
            }
            if (gpa == 0.0m)
            {
                lblGrade.Text = "Your Grade is : F";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGpa.Text = string.Empty;
            lblGrade.Text = string.Empty;
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
