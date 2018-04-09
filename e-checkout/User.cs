using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout
{
    class User
    {
        private int _idUser;
        private string _nomUser;
        private string _prenomUser;
        private string _login;
        private string _password;
        private bool _isAdmin;

        /* public User(int idUser, string nomUser, string prenomUser, string login, string password, bool isAdmin)
         {
             this._idUser = idUser;
             this._nomUser = nomUser;
             this._prenomUser = prenomUser;
             this._login = login;
             this._password = password;
             this._isAdmin = isAdmin;
         } */

        public void SetNom(string newNom)
        {
            this._nomUser = newNom;
        }

        public string GetNom()
        {
            return this._nomUser;
        }

        public void SetPrenom(string newPrenom)
        {
            this._prenomUser = newPrenom;
        }

        public string GetPrenom() {
            return this._prenomUser;
        }

        public void SetLogin(string newLogin)
        {
            this._login = newLogin;
        }

        public string GetLogin() {
            return this._login;
        }

        public void SetPassword(string newPassword)
        {
            this._password = newPassword;
        }

        public string GetPassword() {
            return this._password;
        }

        public void SetIsAdmin(bool newIsAdmin)
        {
            this._isAdmin = newIsAdmin;
        }

        public bool GetIsAdmin() {
            return this._isAdmin;
        }
    }
}
