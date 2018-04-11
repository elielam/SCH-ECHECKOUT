using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout.Classes
{
    public class Product
    {
        private int _id;
        private int _idCategory;
        private string _libelle;
        private float _price;

        public void SetId(int newId)
        {
            this._id = newId;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetIdCategory(int newIdCategory)
        {
            this._idCategory = newIdCategory;
        }

        public int GetIdCategory()
        {
            return this._idCategory;
        }

        public void SetLibelle(string newLibelle)
        {
            this._libelle = newLibelle;
        }

        public string GetLibelle()
        {
            return this._libelle;
        }

        public void SetPrice(float newPrice)
        {
            this._price = newPrice;
        }

        public float GetPrice()
        {
            return this._price;
        }

        public void Init(DataSet ds)
        {
            this.SetId(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()));
            this.SetIdCategory(Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()));
            this.SetLibelle(ds.Tables[0].Rows[0][2].ToString());
            this.SetPrice(Convert.ToSingle(ds.Tables[0].Rows[0][3].ToString()));
        }
    }
}
