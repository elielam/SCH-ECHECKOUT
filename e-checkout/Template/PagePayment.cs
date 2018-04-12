using e_checkout.Classes;
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
    public partial class PagePayment : Form
    {
        private string _classes = "payment";
        private int _selectedId = 2;

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
            DataSet paymentReq = bdd.SelectAllPayment();

            DataSet selectedPaymentReq = bdd.GetPaymentById(this._selectedId);
            Payment selectedPayment = new Payment();
            selectedPayment.Init(selectedPaymentReq);

            DataSet selectedCartReq = bdd.GetCartById(selectedPayment.GetIdCart());
            Cart selectedCart = new Cart();
            selectedCart.Init(selectedCartReq);

            DataSet selectedCartVendorReq = bdd.GetUserById(selectedCart.GetIdUser());
            User selectedCartVendor = new User();
            selectedCartVendor.Init(selectedCartVendorReq);

            DataSet selectedCartProductsReq = bdd.GetAllCartProducts(selectedCart.GetId());
            foreach(DataRow cartStoreItem in selectedCartProductsReq.Tables[0].Rows)
            {
                DataSet tmpProduct = bdd.GetProductById(Convert.ToInt32(cartStoreItem[2].ToString()));
            }

            dataGridViewProducts.DataSource = selectedCartProductsReq.Tables[0];

            labelClientName.Text = selectedPayment.GetClientName() + " " + selectedPayment.GetClientLastname();
            labelPaymentMethod.Text = selectedPayment.GetMethodPayment();
            labelClientAdress.Text = selectedPayment.GetClientAdress();
            labelClientCity.Text = selectedPayment.GetClientCity() + " , " + selectedPayment.GetClientCp();

            labelVendor.Text = selectedCartVendor.GetUsername();

            dataGridViewPayment.DataSource = paymentReq.Tables[0];
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
