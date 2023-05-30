using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class ShirtDiscountGUI : Form
    {
        const float SHIRT_PRICE = 13.75f;
        const float PRICE_TAX = 0.08f;

        public ShirtDiscountGUI()
        {
            InitializeComponent();
        }

        private void ShirtDiscountGUI_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowInvoice();


        }
        private void ShowInvoice()
        {
            int shirtCount = Convert.ToInt32(txtQuantity.Text);
            float discount = 1;
            int discountCode = Convert.ToInt32(txtDiscountCode.Text);

            if (discountCode == 8264)
            {
                discount = SHIRT_PRICE * 0.7f;
            }

            if (discountCode == 5679)
            {
                discount = SHIRT_PRICE * 0.8f;
            }

            if (discountCode == 6483)
            {
                discount = SHIRT_PRICE * 0.9f;
            }

  
            float subtotal = discount * shirtCount;
            float taxTotal = PRICE_TAX * subtotal;
            float finalTotal = subtotal + taxTotal;
            


            rchOrder.Text = $"{shirtCount} Shirts @ {discount:c} each \r\n -------------------------  \r\n Subtotal: {subtotal:c} \r\n Tax: {taxTotal:c}  \r\n Total: {finalTotal:c}";





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
            txtDiscountCode.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            rchOrder.Text = string.Empty;
        }
    }
}
