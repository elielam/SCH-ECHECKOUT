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

        private string _title;

        public AddModal(string title)
        {
            InitializeComponent();
            this._title = title;
        }

        private void AddModal_Load(object sender, EventArgs e)
        {
            label1.Text = this._title;
        }
    }
}
