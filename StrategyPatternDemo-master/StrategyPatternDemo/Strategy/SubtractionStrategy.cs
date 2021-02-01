using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo.Strategy
{
    class SubtractionStrategy : Ianimal
    {
        public void doing(string typeOfAnimal)
        {
            Console.WriteLine("The " + typeOfAnimal + " is sad because you sold it");
        }
    }
}
