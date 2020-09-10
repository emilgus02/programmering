using System;
using System.Globalization;

namespace looooopar
{
    class Program
    {
        static void Main(string[] args)
        {
            string liv;
            int nummer = 2;

            Console.WriteLine("Skriv in ditt namn");
            string namn = Console.ReadLine();
            Console.WriteLine("Skriv in din ålder");
            int alder = Convert.ToInt32(Console.ReadLine());
            Console.Write("Är du vid liv?");

            for (int i = 2; i == nummer;)
            {

                Console.WriteLine(" skriv ja eller nej");
                liv = Console.ReadLine();
                if (liv == "ja" || liv == "nej")
                {
                    i = 3;
                }
                if (liv == "ja")
                {
                    Console.WriteLine("Du heter " + namn + ", du är " + alder + " år gammal och du är vid liv");
                }
                else
                {
                    Console.WriteLine("Du heter " + namn + ", du är " + alder + " år gammal och du är inte vid liv");
                }
            }
            bool hej = true;

            Console.WriteLine("Vill du ha?");
            Console.WriteLine("(1) en Cola");
            Console.WriteLine("(2) en Fanta");
            Console.WriteLine("(3) en Red Bull");
            Console.WriteLine("(4) en Sprite");
            Console.WriteLine("(5) lite Vatten");

            while (hej)
            {
                int val = Convert.ToInt32(Console.ReadLine());

                switch (val) 
                {
                    case 1:
                        Console.WriteLine("Här har du en Cola");
                        break;

                    case 2:
                        Console.WriteLine("Här har du en Fanta");
                        break;

                    case 3:
                        Console.WriteLine("Här har du en Red Bull");
                        break;

                    case 4:
                        Console.WriteLine("Här har du en Sprite");
                        break;

                    case 5:
                        Console.WriteLine("Här har du lite vatten");
                        break;
                }

                Console.WriteLine("Vill du ha en till dricka");
                


                do
                {
                    Console.WriteLine("ja eller nej");
                    String igen = Console.ReadLine();

                    if (igen == "nej")
                    {
                        hej = false;
                    }
                } while (hej == false);
            }
        }
    }
}
