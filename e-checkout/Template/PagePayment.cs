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

            DataTableManager manager = new DataTableManager();
            DataSet selectedCartProductsReq = bdd.GetAllCartProducts(selectedCart.GetId());

            double totalCartPrice = 0;
            int nbrCartItems = 0;

            // Data grid view products need to show selectedProducts
            BindingSource bindingSourceProducts = new BindingSource();

            List<Product> selectedProducts = new List<Product>();
            foreach (DataRow cartStoreItem in selectedCartProductsReq.Tables[0].Rows)
            {
                DataSet tmpProductReq = bdd.GetProductById(Convert.ToInt32(cartStoreItem[2].ToString()));
                Product product = new Product();
                product.Init(tmpProductReq);
<<<<<<< HEAD
=======
                totalCartPrice += Convert.ToDouble(product.GetPrice());
                nbrCartItems++;
                selectedProducts.Add(product);

                // Data grid view products need to show selectedProducts
                bindingSourceProducts.Add(product);
>>>>>>> ce03e4e41fade865c26767ebe70f01731f8e250e
            }

            // Data grid view products need to show selectedProducts
            dataGridViewProducts.DataSource = bindingSourceProducts;

            labelClientName.Text = selectedPayment.GetClientName() + " " + selectedPayment.GetClientLastname();
            labelPaymentMethod.Text = selectedPayment.GetMethodPayment();
            labelClientAdress.Text = selectedPayment.GetClientAdress();
            labelClientCity.Text = selectedPayment.GetClientCity() + " , " + selectedPayment.GetClientCp();

            labelVendor.Text = selectedCartVendor.GetUsername();
            labelItemsNumber.Text = nbrCartItems.ToString() + " Items in cart"; 
            labelTotalPrice.Text = totalCartPrice.ToString() + " €";

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
