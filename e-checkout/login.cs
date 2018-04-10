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

            string anonLogin = textBoxUsername.Text;
            string anonPassword = textBoxPassword.Text;

            DataSet resRequest = bdd.Login(anonLogin, anonPassword);

            if (resRequest.Tables[0].Rows[0][0].ToString() == "1")
            {
                labelFlashMessage.Text = "Connected";

                DataSet userRequest = bdd.GetUserById(anonLogin);

                User user = new User();
                user.SetId(Convert.ToInt32(userRequest.Tables[0].Rows[0][0].ToString()));
                user.SetNom(userRequest.Tables[0].Rows[0][1].ToString());
                user.SetPrenom(userRequest.Tables[0].Rows[0][2].ToString());
                user.SetLogin(userRequest.Tables[0].Rows[0][3].ToString());
                user.SetPassword(userRequest.Tables[0].Rows[0][4].ToString());
                user.SetIsAdmin(Convert.ToBoolean(userRequest.Tables[0].Rows[0][5].ToString()));

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
