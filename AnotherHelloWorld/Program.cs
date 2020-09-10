using System;

namespace AnotherHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] namn = { "Emil", "Niklas", "Linnn", "Niklas", "Malte" };

            Array.Reverse(namn);
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            } 

        }
    }
}

