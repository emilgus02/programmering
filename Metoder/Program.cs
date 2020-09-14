using System;
using System.Linq;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[5];
            string[] name = new string[5];
            int[] big = new int[5];

            Console.WriteLine(summa(tal));

            words(name);

            for (int i = 0; i < big.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Skriv ett tal");
                big[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Det största talet är " + biggest(big).Item1 + " Det minsta talet är " + biggest(big).Item2);

        }
        static int summa(int[] tal)
        {

            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine("Skriv ett tal");
                tal[i] = Convert.ToInt32(Console.ReadLine());
            }

            int add = 0;
            for (int i = 0; i < tal.Length; i++)
            {
                add = tal[i] + add;

            }


            return add;
        }

        static void words(string[] name)
        {
            

            Console.WriteLine("Skriv ett namn");

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Console.ReadLine();

                Console.WriteLine("Skriv ett till namn");
            }

            Array.Reverse(name);

            Console.WriteLine();

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

        }

        static Tuple<int,int> biggest(int[] big)
        {

            int max = big.Max();
            int min = big.Min();

            return new Tuple<int, int>(max, min);
        }
    }
}
