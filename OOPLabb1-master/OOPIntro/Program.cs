using System;
using System.Collections.Generic;

namespace OOPIntro
{
    class Program
    {
        public static RedBull _red = new RedBull();
        public static CocaCola _cola = new CocaCola();
        public static Nocco _nocco = new Nocco();
        public static List<string> _cart = new List<string>();

        static void Main(string[] args)
        {
            _red.flavor = "Red Bull Casual";
            _red.Stock = 5;
            _red.cost = 30;

            _cola.flavor = "CocaCola Casual";
            _cola.Stock = 5;
            _cola.cost = 20;

            _nocco.flavor = "Nocco Tropical";
            _nocco.Stock = 5;
            _nocco.cost = 10;

            bool playAgain = true;
            while (playAgain == true)
            {
                Console.WriteLine("Vill du köpa något? Skriv ja");
                if (Console.ReadLine().ToLower() == "ja")
                {
                    chooseProd();
                }

                Console.WriteLine("Vill du kolla på din vagn? Skriv ja");
                if (Console.ReadLine().ToLower() == "ja")
                {
                    int payment = 0;
                    for (int i = 0; i < _cart.Count; i++)
                    {
                        Console.WriteLine(_cart[i]);

                        if (_cart[i] == _red.flavor)
                        {
                            payment = _red.cost + payment;
                        }
                        else if (_cart[i] == _cola.flavor)
                        {
                            payment = _cola.cost + payment;
                        }
                        else if (_cart[i] == _nocco.flavor)
                        {
                            payment = _nocco.cost + payment;
                        }
                    }
                    Console.WriteLine("Kostnaden är " + payment);

                }
                else
                {
                    Console.WriteLine("Suck a duck!");
                }
                bool idiot = true;
                do
                {

                    Console.WriteLine("Vill du köpa mer ja eller nej?");
                    string again = Console.ReadLine().ToLower();
                    if (again == "ja")
                    {
                        idiot = false;
                    } else if (again == "nej")
                    {
                        playAgain = false;
                    } 
                } while (idiot == true);
            }
        }

        private static void chooseProd()
        {

            Console.WriteLine("Vilken dricka vill du ha?");
            Console.WriteLine("(1) " + _red.flavor);
            Console.WriteLine("(2) " + _cola.flavor);
            Console.WriteLine("(3) " + _nocco.flavor);

            switch (Console.ReadLine())
            {
                case "1":
                    if (!(_red.Stock == 0))
                    {
                        _cart.Add(_red.flavor);
                        _red.Stock = _red.Stock - 1;
                    }
                    else
                    {
                        Console.WriteLine("Det finns ingen kvar");
                    }
                    break;

                case "2":
                    if (!(_cola.Stock == 0))
                    {
                        _cart.Add(_cola.flavor);
                        _cola.Stock = _cola.Stock - 1;
                    }
                    else
                    {
                        Console.WriteLine("Det finns ingen kvar");
                    }
                    break;

                case "3":

                    if (!(_nocco.Stock == 0))
                    {
                        _cart.Add(_nocco.flavor);
                        _nocco.Stock = _nocco.Stock - 1;
                    }
                    else
                    {
                        Console.WriteLine("Det finns ingen kvar");
                    }
                    break;
            }

        }

    }
}
