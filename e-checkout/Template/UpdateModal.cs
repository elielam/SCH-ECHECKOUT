using e_checkout.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_checkout.Template
{
    public partial class UpdateModal : Form
    {

        private string _classes;
        private int _id;

        public UpdateModal(string classes, int id)
        {
            this._classes = classes;
            this._id = id;

            Bdd bdd = new Bdd();
            switch (this._classes)
            {
                case "stock":
                    DataSet stockReq = bdd.GetStockById(this._id);
                    Stock stock = new Stock();
                    stock.Init(stockReq);
                    this.InitializeComponentStock(stock);
                    break;
                case "user":
                    DataSet userReq = bdd.GetUserById(this._id);
                    User user = new User();
                    user.Init(userReq);
                    this.InitializeComponentUser(user);
                    break;
                case "product":
                    DataSet productReq = bdd.GetProductById(this._id);
                    Product product = new Product();
                    product.Init(productReq);
                    this.InitializeComponentProduct(product);
                    break;
                case "payment":
                    DataSet paymentReq = bdd.GetPaymentById(this._id);
                    Payment payment = new Payment();
                    payment.Init(paymentReq);
                    this.InitializeComponentPayment(payment);
                    break;
            }

        }

        private void UpdateModal_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();
            switch (this._classes)
            {
                case "stock":
                    Stock stock = new Stock();
                    stock.SetId(Convert.ToInt32(textBoxId.Text));
                    stock.SetIdProduct(Convert.ToInt32(textBoxProduct.Text));
                    stock.SetQuantity(Convert.ToDouble(textBoxQuantity.Text));
                    bdd.UpdateStock(stock);
                    break;
                case "user":
                    User user = new User();
                    user.SetId(Convert.ToInt32(textBoxId.Text));
                    user.SetName(textBoxName.Text);
                    user.SetLastname(textBoxLastname.Text);
                    user.SetUsername(textBoxUsername.Text);
                    user.SetIsAdmin(Convert.ToBoolean(textBoxIsAdmin.Text));

                    if(textBoxPassword.Text == "")
                    {
                        User sampleUser = new User();
                        DataSet sampleUserReq = bdd.GetUserById(user.GetId());
                        sampleUser.Init(sampleUserReq);
                        user.SetPassword(sampleUser.GetPassword());
                    } else
                    {
                        user.SetPassword(textBoxPassword.Text);
                    }

                    bdd.UpdateUser(user);
                    break;
                case "product":
                    Product product = new Product();
                    product.SetId(Convert.ToInt32(textBoxId.Text));
                    product.SetIdCategory(Convert.ToInt32(textBoxCategory.Text));
                    product.SetLibelle(textBoxLibelle.Text);
                    product.SetPrice(Convert.ToSingle(textBoxPrice.Text));
                    bdd.UpdateProduct(product);
                    break;
                case "payment":
                    Payment payment = new Payment();
                    payment.SetId(Convert.ToInt32(textBoxId.Text));
                    payment.SetIdCart(Convert.ToInt32(textBoxCart.Text));
                    bdd.UpdatePayment(payment);
                    break;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
