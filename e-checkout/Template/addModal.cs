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
    public partial class AddModal : Form
    {
        private string _classes;

        public AddModal(string classes)
        {
            this._classes = classes;
            
            switch (this._classes)
            {
                case "stock":
                    this.InitializeComponentStock();
                    break;
                case "user":
                    this.InitializeComponentUser();
                    break;
                case "product":
                    this.InitializeComponentProduct();
                    break;
                case "payment":
                    this.InitializeComponentPayment();
                    break;
            }
        }

        private void AddModal_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
