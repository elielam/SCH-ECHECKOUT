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

        private string _classes = "product";
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
            if(this._classes == "stock")
            {
                DataSet stockReq = bdd.SelectAllStock();
                dataGridViewStock.DataSource = stockReq.Tables[0];
                /* Need to make a list of stock object and give it to test */
            }
            else if(this._classes == "product")
            {
                DataSet productReq = bdd.SelectAllProduct();
                dataGridViewProduct.DataSource = productReq.Tables[0];
            }
            else if(this._classes == "category")
            {
                DataSet categoryReq = bdd.SelectAllCategory();
                dataGridViewCategory.DataSource = categoryReq.Tables[0];
            }
        }

        private void tabPageStock_Click(object sender, EventArgs e)
        {
            this._classes = "stock";
        }

        private void tabPageProduct_Click(object sender, EventArgs e)
        {
            this._classes = "product";
        }

        private void tabPageCategory_Click(object sender, EventArgs e)
        {
            this._classes = "stock";
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            AddModal addModal = new AddModal(this._classes);
            addModal.Show();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddModal addModal = new AddModal(this._classes);
            addModal.Show();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddModal addModal = new AddModal(this._classes);
            addModal.Show();
        }

        private void buttonUpdateStock_Click(object sender, EventArgs e)
        {
            UpdateModal updateModal = new UpdateModal(this._classes, this._selectedId);
            updateModal.Show();
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateModal updateModal = new UpdateModal(this._classes, this._selectedId);
            updateModal.Show();
        }

        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            UpdateModal updateModal = new UpdateModal(this._classes, this._selectedId);
            updateModal.Show();
        }

        private void buttonDeleteStock_Click(object sender, EventArgs e)
        {
            test test = new test();
            test.Show();
        }
    }
}
