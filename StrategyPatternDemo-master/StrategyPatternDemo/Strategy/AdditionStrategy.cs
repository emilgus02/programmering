using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo.Strategy
{
    class AdditionStrategy : Ianimal
    {
        public void doing(string typeOfAnimal)
        {
            Console.WriteLine("The " + typeOfAnimal + " is smiling because you adoptet it");
        }
    }
}
