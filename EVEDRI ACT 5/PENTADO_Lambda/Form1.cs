using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PENTADO_Lambda
{
    public partial class Form1 : Form
    {
        private object txtQuantity;

        public Form1()
        {
            InitializeComponent();

            btnCheckOrder.Click += (sender, e) =>
            {
                if (int.TryParse(txtQuantityinput.Text, out int quantity) && quantity > 0)
                {
                    lblResult.Text = "Order Accepted";
                    lblResult.ForeColor = Color.Green;
                }
                else
                {
                    lblResult.Text = "Invalid Order";
                    lblResult.ForeColor = Color.Red;
                }
            };

        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
