using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX4
{
    public partial class LawnCareGUI : Form
    {
        const int SEASON_LENGTH = 20;
        
        public LawnCareGUI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(txtLength.Text);
            double width = Convert.ToDouble(txtWidth.Text);
            double totalArea = CalculateTotalArea(length, width);
            double fee = 0;
            if (totalArea >= 600 )
            {
                fee = 50;
            }
            if (totalArea >= 400 && totalArea < 600)
            {
                fee = 35;
            }
            if (totalArea < 400)
            {
                fee = 25;
            }
            double total = fee * SEASON_LENGTH;

            rchOrder.Text = $"Area:    {totalArea} Square Feet \r\nWeekly Fee:    {fee:c}\r\nSeason Length:    {SEASON_LENGTH} weeks \r\nTotal:    {total:c}";

        }

        private double CalculateTotalArea(double length, double width)
        {
            double totalArea = length * width ;
            return totalArea;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLength.Text = string.Empty;
            txtWidth.Text = string.Empty;
            rchOrder.Text = string.Empty;
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
