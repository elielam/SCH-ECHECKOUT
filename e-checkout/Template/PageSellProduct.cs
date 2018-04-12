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
        private List<Product> products;
        public PageSellProduct()
        {
            Bdd bdd = new Bdd();
            DataSet productsReq = bdd.SelectAllProduct();

            foreach (DataRow productRow in productsReq.Tables[0].Rows)
            {
                DataSet dsTest = new DataSet();
                DataTable dtTest = new DataTable();
                dsTest.Tables.Add(dtTest);
                dtTest.Rows.Add(productRow.ItemArray);
                Product product = new Product();
                product.Init(dsTest);
                products.Add(product);
                Console.WriteLine(product.GetLibelle());
            }

            InitializeComponent(products);
        }
    }
}
