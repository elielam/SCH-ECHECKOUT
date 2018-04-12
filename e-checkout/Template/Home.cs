using e_checkout.Template;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_checkout
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if(!Program.LoggedUser.GetIsAdmin())
            {
                buttonStock.Enabled = false;
                buttonUser.Enabled = false;
            }
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pageStock = new PageStock();
            pageStock.Closed += (s, args) => this.Close();
            pageStock.Show();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pageUser = new pageUser();
            pageUser.Closed += (s, args) => this.Close();
            pageUser.Show();
        }

        private void buttonHistorique_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pagePayment = new PagePayment();
            pagePayment.Closed += (s, args) => this.Close();
            pagePayment.Show();
        }

        private void buttonCaisse_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pageSellProduct = new PageSellProduct();
            pageSellProduct.Closed += (s, args) => this.Close(); ;
            pageSellProduct.Show();
        }
    }
}
