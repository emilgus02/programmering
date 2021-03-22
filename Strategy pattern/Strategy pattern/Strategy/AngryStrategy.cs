using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern
{
    class AngryStrategy : Ianimal
    {
        public void doing(string typeOfAnimal)
        {
            Console.WriteLine("The " + typeOfAnimal + " bite you because you tried to steal it");
        }
    }
}
