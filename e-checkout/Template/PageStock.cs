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
    public partial class PageStock : Form
    {

        private string _classes = "stock";
        private int _selectedId = 5;

        public PageStock()
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

        private void PageStock_Load(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();
            DataSet stockReq = bdd.SelectAllStock();

            dataGridViewStock.DataSource = stockReq.Tables[0];
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddModal addModal = new AddModal(this._classes);
            addModal.Show();
        }

        private void dataGridViewStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
     
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateModal updateModal = new UpdateModal(this._classes, this._selectedId);
            updateModal.Show();
        }
    }
}
