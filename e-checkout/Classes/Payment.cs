﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout.Classes
{
    public class Payment
    {
        private int _id;
        private int _idCart;

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
    }
}