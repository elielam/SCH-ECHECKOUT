using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout.Classes
{
    public class Stock
    {
        private int _id;
        private int _idProduct;
        private double _quantity;

        public void SetId(int newId)
        {
            this._id = newId;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetIdProduct(int newIdProduct)
        {
            this._idProduct = newIdProduct;
        }

        public int GetIdProduct()
        {
            return this._idProduct;
        }

        public void SetQuantity(double newQuantity)
        {
            this._quantity = newQuantity;
        }

        public double GetQuantity()
        {
            return this._quantity;
        }

        public void Init(DataSet ds)
        {
            this.SetId(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()));
            this.SetIdProduct(Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()));
            this.SetQuantity(Convert.ToDouble(ds.Tables[0].Rows[0][2].ToString()));
        }
    }
}
