﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi
{
    class Milk : Product
    {
        private int _fatContent;

        public int fatContent
        {
            get { return _fatContent; }
            set { _fatContent = value; }
        }



    }
}
