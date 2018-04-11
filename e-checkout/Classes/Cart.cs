using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout.Classes
{
    public class Cart
    {
        private int _id;
        private int _idUser;

        public void SetId(int newId)
        {
            this._id = newId;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetIdUser(int newIdUser)
        {
            this._idUser = newIdUser;
        }

        public int GetIdUser()
        {
            return this._idUser;
        }

        public void Init(DataSet ds)
        {
            this.SetId(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()));
            this.SetIdUser(Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()));
        }
    }
}
