using System;

namespace AnotherHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] namn = new string[5];

            Console.WriteLine("Skriv ett namn");

            for (int i = 0; i < namn.Length; i++)
            {
                namn[i] = Console.ReadLine();

                Console.WriteLine("Skriv ett till namn");
            }

            Array.Reverse(namn);

            Console.WriteLine();

            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }

            }   
        }
    }


