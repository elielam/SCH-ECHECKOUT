using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout.Classes
{
    public class Payment
    {
        private int _id;
        private int _idCart;
        private string _methodPayment;
        private string _clientName;
        private string _clientLastname;
        private string _clientAdress;
        private string _clientCity;
        private string _clientCp;

        public void SetId(int newId)
        {
            this._id = newId;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetMethodPayment(string newMethodPayment)
        {
            this._methodPayment = newMethodPayment;
        }

        public string GetMethodPayment()
        {
            return this._methodPayment;
        }

        public void SetIdCart(int newIdCart)
        {
            this._idCart = newIdCart;
        }

        public int GetIdCart()
        {
            return this._idCart;
        }

        public void SetClientName(string newClientName)
        {
            this._clientName = newClientName;
        }

        public string GetClientName()
        {
            return this._clientName;
        }

        public void SetClientLastname(string newClientLastname)
        {
            this._clientLastname = newClientLastname;
        }

        public string GetClientLastname()
        {
            return this._clientLastname;
        }

        public void SetClientAdress(string newClientAdress)
        {
            this._clientAdress = newClientAdress;
        }

        public string GetClientAdress()
        {
            return this._clientAdress;
        }

        public void SetClientCity(string newClientCity)
        {
            this._clientCity = newClientCity;
        }

        public string GetClientCity()
        {
            return this._clientCity;
        }

        public void SetClientCp(string newClientCp)
        {
            this._clientCp = newClientCp;
        }

        public string GetClientCp()
        {
            return this._clientCp;
        }

        public void Init(DataSet ds)
        {
            this.SetId(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()));
            this.SetIdCart(Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()));
            this.SetMethodPayment(ds.Tables[0].Rows[0][2].ToString());
            this.SetClientName(ds.Tables[0].Rows[0][3].ToString());
            this.SetClientLastname(ds.Tables[0].Rows[0][4].ToString());
            this.SetClientAdress(ds.Tables[0].Rows[0][5].ToString());
            this.SetClientCity(ds.Tables[0].Rows[0][6].ToString());
            this.SetClientCp(ds.Tables[0].Rows[0][7].ToString());
        }
    }
}
