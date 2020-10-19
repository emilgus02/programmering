using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
    class Nocco : Product
    {
        private string _flavor;

        public string flavor
        {
            get { return _flavor; }
            set { _flavor = value; }
        }
    }
}
