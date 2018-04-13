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
    public partial class PageSellProduct : Form
    {
        private List<Product> _products = new List<Product>();
        public static List<Product> _productsCart = new List<Product>();
        public PageSellProduct()
        {
            Bdd bdd = new Bdd();
            DataSet productsReq = bdd.SelectAllProduct();
            foreach (DataRow productRow in productsReq.Tables[0].Rows)
            {
                DataSet dsTest = new DataSet();
                DataTable dtTest = productsReq.Tables[0].Clone();
                dtTest.ImportRow(productRow);
                dsTest.Tables.Add(dtTest);
                Product product = new Product();
                product.Init(dsTest);
                _products.Add(product);
            }

            InitializeComponent(_products);
        }
    }
}
