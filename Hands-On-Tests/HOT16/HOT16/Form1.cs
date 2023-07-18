namespace HOT16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grpCreate_Enter(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                double loan = Convert.ToDouble(value: txtAmount.Text);
                double shortTerm = loan - 200;
                double shortInterest = shortTerm * 1.05;
                double longTerm = loan - 450;
                double longInterest = longTerm * 1.10;

                if (rdoShortTerm.Checked)
                {
                    lblRemain.Text = "After the last payment, the loan is now down to " + $"{shortTerm:c}";
                    lblInterest.Text = "After the last interest Accumulation the loan is now " + $"{shortInterest:c}";

                }

                if (rdoLongTerm.Checked)
                {
                    lblRemain.Text = "After the last payment, the loan is now down to " + $"{longTerm:c}";
                    lblInterest.Text = "After the last interest Accumulation the loan is now " + $"{longInterest:c}";

                }
            }
        }

        private void lblInterest_Click(object sender, EventArgs e)
        {

        }



        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            double loan = Convert.ToDouble(value: txtAmount.Text);


            if (rdoShortTerm.Checked && loan > 1)
            {
                grpManage.Visible = true;
                lblName.Text = txtName.Text;
                lblType.Text = "Short-Term loan of " + $"{loan:c}";
                lblError.Visible = false;
            }

            if (rdoShortTerm.Checked && loan <= 0)
            {
                grpManage.Visible = false;
                lblError.Visible = true;
            }

            if (rdoLongTerm.Checked && loan > 1)
            {
                grpManage.Visible = true;
                lblName.Text = txtName.Text;
                lblType.Text = "Long-Term loan of " + $"{loan:c}";
                lblError.Visible = false;

            }

            if (rdoLongTerm.Checked && loan <= 0)
            {
                grpManage.Visible = false;
                lblError.Visible = true;
            }

        }

        private void rdoLongTerm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoShortTerm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRemain_Click(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void grpManage_Enter(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }



    }
}