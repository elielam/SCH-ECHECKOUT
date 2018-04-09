using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout
{
    class User
    {
        public int _idUser;
        public string _nomUser;
        public string _prenomUser;
        public string _login;
        public string _password;
        public bool _isAdmin;

       /* public User(int idUser, string nomUser, string prenomUser, string login, string password, bool isAdmin)
        {
            _idUser = idUser;
            _nomUser = nomUser;
            _prenomUser = prenomUser;
            _login = login;
            _password = password;
            _isAdmin = isAdmin;
        } */

        public void SetNom(string newNom)
        {
            _nomUser = newNom;
        }

        public string GetNom()
        {
            return _nomUser;
        }

        public void SetPrenom(string newPrenom)
        {
            _prenomUser = newPrenom;
        }

        public string GetPrenom() {
            return _prenomUser;
        }

        public void SetLogin(string newLogin)
        {
            _login = newLogin;
        }

        public string GetLogin() {
            return _login;
        }

        public void SetPassword(string newPassword)
        {
            _password = newPassword;
        }

        public string GetPassword() {
            return _password;
        }

        public void SetIsAdmin(bool newIsAdmin)
        {
            _isAdmin = newIsAdmin;
        }

        public bool GetIsAdmin() {
            return _isAdmin;
        }
    }
}
