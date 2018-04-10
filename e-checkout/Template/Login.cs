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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            string anonUsername = textBoxUsername.Text;
            string anonPassword = textBoxPassword.Text;

            DataSet resReq = bdd.Login(anonUsername, anonPassword);

            if (resReq.Tables[0].Rows[0][0].ToString() == "1")
            {
                labelFlashMessage.Text = "Connected";

                DataSet userReq = bdd.GetUserByUsername(anonUsername);

                User user = new User();
                user.Init(userReq);

                Program.LoggedUser = user;

                this.Hide();
                var home = new Home();
                home.Closed += (s, args) => this.Close();
                home.Show();
            } else
            {;
                MessageBox.Show("Login Error");
            }
        }
    }
}
