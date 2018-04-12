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
    public partial class pageUser : Form
    {
        private string _classes = "user";
        private int _selectedId = 2;

        public pageUser()
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

        private void pageUser_Load(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();
            DataSet userReq = bdd.SelectAllUser();

            dataGridViewUser.DataSource = userReq.Tables[0];
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddModal addModal = new AddModal(this._classes);
            addModal.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateModal updateModal = new UpdateModal(this._classes, this._selectedId);
            updateModal.Show();
        }
    }
}
