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
    public partial class frmHelp : Form
    {
        string helpStr = "";
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            BuildHelpString();
            lblHelpText.Text = helpStr;
        }

         private void BuildHelpString()
        {
            helpStr += "\nCreate a C# Book Store Application that stores books for a minimum of 3 authors.";
            helpStr += "\nThis data must be stored in a List<Book> to receive credit.";
            helpStr += "\nOne author should have less than 5 books ";
            helpStr += "\nOne author should have between 5 – 10 books";
            helpStr += "\nOne author should have greater than 10 books ";
            helpStr += "\nUse real book information that can be found online ";
            helpStr += "\n\tThe Author DropDown List should allow for filtering results by Author from the Search Form (using the LINQ Where() function)";
            helpStr += "\n\n\tThis dropdown list should be programmatically populated when the form loads (using the Select() and Unique() functions) ";
            helpStr += "\n\tOn the Search Form when the user clicks the search button, a LINQ search can be performed by both (using the LINQ Where() function): \n";
            helpStr += "\n\tOn the Search Form after the search button is clicked, the correct result data should be returned and displayed below the search controls. \nResult data includes: \r\n❏\tBook ISBN.\r\n❏\tBook Title.\r\n❏\tBook Author.\r\n❏\tYear the book was published.\r\n❏\tIf more than 5 results are returned, the application should implement paging.\nAny search results with less than 5 books should disable or hide the paging controls.\n(Use the LINQ Skip() and Take() functions to page the results. \nDon’t forget to round up when determining the # of pages in the result!).\r\n";
            helpStr += "";
            helpStr += "";
            helpStr += "";
            helpStr += "";



        }

        private void lblHelpText_Click(object sender, EventArgs e)
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
