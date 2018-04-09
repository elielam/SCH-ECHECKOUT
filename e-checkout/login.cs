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

            /* User user = new User();
            user.SetId(1);
            user.SetNom("test");
            user.SetPrenom("test");
            user.SetLogin(anonLogin);
            user.SetPassword(anonPassword);
            user.SetIsAdmin(false);*/

            labelUsername.Text = anonLogin;
            labelPassword.Text = anonPassword;

            labelPOS.Text = bdd.Login(anonLogin, anonPassword).ToString();
        }
    }
}
