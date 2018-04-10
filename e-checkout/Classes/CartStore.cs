﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout.Classes
{
    public class CartStore
    {
        private int _id;
        private int _idCart;
        private int _idProduct;

        public void SetId(int newId)
        {
            this._id = newId;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetIdCart(int newIdCart)
        {
            this._idCart = newIdCart;
        }

        public int GetIdCart()
        {
            return this._idCart;
        }

        public void SetIdProduct(int newIdProduct)
        {
            this._idProduct = newIdProduct;
        }

        public int GetIdProduct()
        {
            return this._idProduct;
        }
    }
}
