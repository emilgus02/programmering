using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern
{
    class SadStrategy : Ianimal
    {
        public void doing(string typeOfAnimal)
        {
            Console.WriteLine("The " + typeOfAnimal + " is sad because you sold it");
        }
    }
}
