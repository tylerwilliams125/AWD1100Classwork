using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmScoreAverage : Form
    {
        public frmScoreAverage()
        {
            InitializeComponent();
        }
        const int MINTESTSCORE = 0;
        const int MAXTESTSCORE = 100;

        int scoreTotal;
        int scoreCount;
        double average;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AttemptToAddScore();
        }

        private void AttemptToAddScore()
        {
            bool result = false;
            bool retVal = true;
            int score = 0;

            if(txtScore.Text.Trim() =="")
            {
                ShowMessage("Score Cannot Be Empty",
                    "NOTHING INPUTTED FOR SCORE");
                txtScore.Focus();

                return;
            }

            result= Int32.TryParse(txtScore.Text, out score);
            if(!result )
            {
                ShowMessage("Score must be numeric (0-100)",
                    "NON-NUMERIC INPUT FOR SCORE");
                txtScore.Focus();
                return;
            }

            if((score < MINTESTSCORE) || (score > MAXTESTSCORE))
            {
                ShowMessage("Out of Range. Score Must Be (0-100)",
                            "OUT OF RANGE INPUT FOR SCORE");
                txtScore.Focus();
                txtScore.Text="";
                return;
            }
            ++scoreCount;

            scoreTotal += score;

            average = (double)scoreTotal / (double)scoreCount;

            txtScore.Text = "";
            txtTotal.Text = scoreTotal.ToString();
            txtCount.Text = scoreCount.ToString();
            txtAverage.Text = average.ToString();
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information); 

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore.Clear();
            txtCount.Clear();
            txtAverage.Clear();
            txtTotal.Clear();
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
