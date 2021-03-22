using System;

namespace OBP
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel();
            Random rnd = new Random();

            Subscriber subscriber = new Subscriber("Subcriber: Niklas");
            Console.WriteLine("Hello Niklas");

            Console.WriteLine("Which youtube channel do you want to subscribe to?");
            Console.WriteLine("(1) Ninja");
            Console.WriteLine("(2) Kim Kardashian");
            Console.WriteLine("(3) Logan Paul");
            Console.WriteLine("(4) None");

            string channelName = Console.ReadLine();

            channel.Inventory = rnd.Next(2);
        }
    }
}
