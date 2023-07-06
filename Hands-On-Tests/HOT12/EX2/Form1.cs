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
    public partial class Form1 : Form
    {
        Computer[] computers = new Computer[]
        {
            new Computer("My-Desktop","127.0.0.1","20, 21, 23, 25, 53, 80, 123, 389, 443"),
            new Computer("google-public-dns-a","8.8.8.8","53"),
            new Computer("ranken.edu","47.44.246.80","25, 80, 443"),
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string ipAddress = txtScan.Text;
            ScanIpAddress(ipAddress);

        }

        public void ScanIpAddress(string ipAddress)
        {
            for (int i = 0; i < computers.Length; i++)
            {

                if (computers[i].IPAddress == ipAddress)
                {
                    lblName.Text = computers[i].Name;
                    lblIP.Text = ipAddress;
                    lblServices.Text = computers[i].Services;
                    break;
                }
                    if (computers[i].IPAddress != ipAddress)
                    {
                        lblName.Text = "Request Timed Out";
                        lblIP.Text = txtScan.Text;
                        lblServices.Text = "NONE";
                    }


            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScan.Text= string.Empty;
            lblIP.Text= string.Empty;
            lblServices.Text= string.Empty;
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
