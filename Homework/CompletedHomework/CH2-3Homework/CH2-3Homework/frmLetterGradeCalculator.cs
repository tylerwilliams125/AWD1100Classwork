﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH2_3Homework
{
    public partial class frmLetterGradeCalculator : Form
    {
        public frmLetterGradeCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string letterGrade = "";
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);
            
            if(numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLetterGrade.Clear();
            txtNumberGrade.Clear();
            txtNumberGrade.Focus();

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
