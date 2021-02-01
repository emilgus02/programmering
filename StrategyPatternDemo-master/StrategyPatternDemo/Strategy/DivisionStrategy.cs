using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo.Strategy
{
    class DivisionStrategy : Ianimal
    {
        public void doing(string typeOfAnimal)
        {
            Console.WriteLine("Okey tell me if you want help with buying the " + typeOfAnimal);
        }
    }
}
