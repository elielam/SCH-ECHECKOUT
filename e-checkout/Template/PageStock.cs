﻿using System;
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
            DataSet stockReq = bdd.SelectAllStock();

            dataGridViewStock.DataSource = stockReq.Tables[0];
        }
    }
}