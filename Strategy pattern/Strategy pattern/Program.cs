using Strategy_pattern.Strategy;
using System;

namespace Strategy_pattern
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

                Console.WriteLine("Enter what animal");
                typeOfAnimal = Console.ReadLine();

                bool reset = false;

                switch (costumer)
                {
                    case "1":
                        strat = new HappyStrategy();
                        break;
                    case "2":
                        strat = new SadStrategy();
                        break;
                    case "3":
                        strat = new AngryStrategy();
                        break;
                    case "4":
                        strat = new LookinStrategy();
                        break;
                    default:
                        Console.WriteLine("Please select a valid operation");
                        reset = true;
                        strat = new HappyStrategy();
                        break;
                }

                if (reset)
                {
                    continue;
                }

                var calc 

                Console.WriteLine("Do you wish to continue? 'y'/'n'");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
    }
}}
