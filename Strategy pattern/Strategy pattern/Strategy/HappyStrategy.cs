using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern
{
    class HappyStrategy : Ianimal
    {
        public void doing(string typeOfAnimal)
        {
            Console.WriteLine("The " + typeOfAnimal + " is smiling because you adoptet it");
        }
    }
}
