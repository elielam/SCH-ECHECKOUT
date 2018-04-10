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
    public partial class PagePayment : Form
    {
        public PagePayment()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Home();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void PagePayment_Load(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();
            DataSet stockReq = bdd.SelectAllPayment();

            dataGridViewPayment.DataSource = stockReq.Tables[0];
        }
    }
}
