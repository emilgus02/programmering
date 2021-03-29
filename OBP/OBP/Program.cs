using System;
using System.Collections.Generic;

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

            int channelName = Convert.ToInt32(Console.ReadLine());

            if (channelName == 1)
            {
                Subscriber Ninja = new Subscriber("Ninja");
                channel.Subscribe(Ninja);
            }
            else if (channelName == 2)
            {
                Subscriber Kim = new Subscriber("Kim Kardashian");
                channel.Subscribe(Kim);
            }
            else if (channelName == 3)
            {
                Subscriber Logan = new Subscriber("Ligan Paul");
                channel.Subscribe(Logan);
            }

            channel.Inventory = rnd.Next(0, 2);
        }
    }
}
