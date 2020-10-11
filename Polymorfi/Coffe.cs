using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi
{
    class Coffe : Product
    {
        private string _roastyness;

        public string roastyness
        {
            get { return _roastyness; }
            set { _roastyness = value; }
        }

    }
}
