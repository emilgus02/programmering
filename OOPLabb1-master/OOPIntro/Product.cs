using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
    class Product
    {
        private int _stock;

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        private int _cost;

        public int cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
    }
}
