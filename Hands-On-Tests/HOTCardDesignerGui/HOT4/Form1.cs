using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT4
{
    public partial class Form1 : Form
    {
        double price = 0;
        const double envelope = 0.25;
        const double stamp = 0.50;
        const double message = 0.30;
        public Form1()
        {
            InitializeComponent();
            cboOccasion.Items.AddRange(GetOccasions());
        }

        public string[] GetOccasions()
        {
            return new string[]
            {
                "Christmas",
                "Valentines Day",
                "White Day"

            };
        }

        public Style[] GetStyles(string occasion)
        {
            switch ($"{occasion}")
            {
                default:
                    return new Style[0];
                case "Christmas":
                    return new Style[]
                    {
                     new Style{Name ="Dog($1.25)", Price= 1.15, Image=Properties.Resources.Dog},
                     new Style{Name ="Nice($1.50)", Price= 1.50, Image=Properties.Resources.Christmas}
                    };
                case "Valentines Day":
                    return new Style[]
                     {
                     new Style{Name ="Geto($1.85)", Price= 1.85, Image=Properties.Resources.Geto},
                     new Style{Name ="Caveman($2.25)", Price= 2.25, Image=Properties.Resources.Rename}
                     };
                case "White Day":
                    return new Style[]
                     {
                     new Style{Name ="Blue($1.75)", Price= 1.75, Image=Properties.Resources.Blue},
                     new Style{Name ="Pink($2.35)", Price= 2.35, Image=Properties.Resources.Pink}
                     };

            }
        }


        private void cboOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string occasion = cboOccasion.SelectedItem.ToString();
            cboStyle.Items.Clear();

            cboStyle.Items.AddRange(GetStyles(occasion));
            cboStyle.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Style s = (Style)cboStyle.SelectedItem;
            string year = cboOccasion.SelectedItem.ToString();
            string style = cboStyle.SelectedItem.ToString();
            double updatedPrice = price + s.Price;

            if (chkEnvelope.Checked && chkStamp.Checked && chkMessage.Checked)
            {
                lblCost.Text = $"{updatedPrice + 1.05:c}";
            }
            if (chkEnvelope.Checked && !chkMessage.Checked && !chkStamp.Checked)
            {
                lblCost.Text = $"{updatedPrice + envelope:c}";
            }
            if (chkStamp.Checked && !chkMessage.Checked && !chkEnvelope.Checked)
            {
                lblCost.Text = $"{updatedPrice + stamp:c}";

            }
            if (chkMessage.Checked && !chkEnvelope.Checked && chkStamp.Checked)
            {
                lblCost.Text = $"{updatedPrice + message:c}";

            }
            else
            {
                lblCost.Text = $"{updatedPrice:c}";
            }
            pbCard.Image = s.Image;


        }

        private void chkEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            Style s = (Style)cboStyle.SelectedItem;

            double updatedPrice = price + s.Price;
            double envelopePrice = updatedPrice + envelope;




            lblCost.Text = $"{envelopePrice:c}";
        }

        private void chkStamp_CheckedChanged(object sender, EventArgs e)
        {
            Style s = (Style)cboStyle.SelectedItem;
            double updatedPrice = price + s.Price;
            double stampPrice = updatedPrice + 0.50;
            if (chkEnvelope.Checked)
            {
                lblCost.Text = $"{stampPrice + 0.25:c}";

            }
            lblCost.Text = $"{stampPrice:c}";

        }

        private void chkMessage_CheckedChanged(object sender, EventArgs e)
        {
            rchMessage.Visible = true;
            lblMessage.Visible = true;

        }

        private void pbCard_Click(object sender, EventArgs e)
        {

        }

        private void rchMessage_TextChanged(object sender, EventArgs e)
        {

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
            cboOccasion.SelectedIndex = 0;
            cboStyle.SelectedIndex = 0;
            pbCard.Visible = false;
            chkEnvelope.Checked = false;
            chkMessage.Checked = false;
            chkStamp.Checked = false;
            rchMessage.Visible = false;
            lblMessage.Visible = false;
            lblCost.Text = string.Empty;

        }
    }
}
