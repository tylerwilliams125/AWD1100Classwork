using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject2
{
    public partial class frmDetails : Form
    {
        public string isbn;
        public string bookName;
        public string authorName;
        public string publishYear;
        public string img;

        public frmDetails()
        {
            InitializeComponent();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            FillupFields();
        }

        private void FillupFields()
        {
          
            lblAuthorName.Text = authorName;
            lblTitle.Text = bookName;
            lblPublishYear.Text = "(" + publishYear + ")";
            lblISBN.Text = isbn;
           
        }



        private void lblAuthorName_Click(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPage main = new frmMainPage();
            main.Show();
        }

        private void btnSplash_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSplash splash = new frmSplash();
            splash.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHelp help = new frmHelp();
            help.Show();
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
