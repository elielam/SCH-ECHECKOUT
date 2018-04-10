using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout
{
    public class User
    {
        private int _id;
        private string _name;
        private string _lastname;
        private string _username;
        private string _password;
        private bool _isAdmin;

        public void SetId(int newId)
        {
            this._id = newId;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetName(string newName)
        {
            this._name = newName;
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetLastname(string newLastname)
        {
            this._lastname = newLastname;
        }

        public string GetLastname() {
            return this._lastname;
        }

        public void SetUsername(string newUsername)
        {
            this._username = newUsername;
        }

        public string GetUsername() {
            return this._username;
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

        public void Init(DataSet ds)
        {
            this.SetId(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()));
            this.SetName(ds.Tables[0].Rows[0][1].ToString());
            this.SetLastname(ds.Tables[0].Rows[0][2].ToString());
            this.SetUsername(ds.Tables[0].Rows[0][3].ToString());
            this.SetPassword(ds.Tables[0].Rows[0][4].ToString());
            this.SetIsAdmin(Convert.ToBoolean(ds.Tables[0].Rows[0][5].ToString()));
        }
    }
}
