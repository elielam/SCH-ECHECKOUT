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
    public partial class test : Form
    {

        private List<Stock> _objectList;

        public test()
        {
            InitializeComponent();
        }

        public void generate()
        {
            
        }

        private void test_Load(object sender, EventArgs e)
        {
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.823529F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.17647F));
            tableLayoutPanel1.Size = new System.Drawing.Size(775, 425);
            tableLayoutPanel1.TabIndex = 0;
            this.Controls.Add(tableLayoutPanel1);
        }
    }
}
