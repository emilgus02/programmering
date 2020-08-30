using System;
using System.Globalization;

namespace HelloWoorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
                } else
                {
                    Console.WriteLine("Du heter " + namn + ", du är " + alder + " år gammal och du är inte vid liv");
                }
            }
        }
    }
}
