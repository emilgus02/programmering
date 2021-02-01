using StrategyPatternDemo.Strategy;
using System;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What du you want to do?");
                Console.WriteLine("Buy an animal (1)");
                Console.WriteLine("Sell an animal (2)");
                Console.WriteLine("Kidnapp an animal (3)");
                Console.WriteLine("Just looking at animals (4)");
                var costumer = Console.ReadLine();
                string typeOfAnimal;
                Ianimal strat;

                Console.WriteLine("Enter the first number:");
                typeOfAnimal = Console.ReadLine();
                
                bool reset = false;

                switch (costumer)
                {
                    case "1":
                        strat = new AdditionStrategy();
                        break;
                    case "2":
                        strat = new SubtractionStrategy();
                        break;
                    case "3":
                        strat = new MultiplicationStrategy();
                        break;
                    case "4":
                        strat = new DivisionStrategy();
                        break;
                    default:
                        Console.WriteLine("Please select a valid operation");
                        reset = true;
                        strat = new AdditionStrategy();
                        break;
                }

                if (reset)
                {
                    continue;
                }

                Console.WriteLine("Do you wish to continue? 'y'/'n'");
                if(Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
