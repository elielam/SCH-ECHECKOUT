﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout.Classes
{
    public class Category
    {
        private int _id;
        private string _libelle;

        public void SetId(int newId)
        {
            this._id = newId;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetLibelle(string newLibelle)
        {
            this._libelle = newLibelle;
        }

        public string GetLibelle()
        {
            return this._libelle;
        }
    }
}
