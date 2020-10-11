using System;
using System.Collections.Generic;

namespace Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> cart = new List<Product>();

            Milk milk = new Milk();
            milk.fatContent = 1;
            milk.ProductNumber = 123;
            milk.stockStatus = 10;

            cart.Add(milk);

            Nocco nocco = new Nocco();
            nocco.flavor = "Cola";
            nocco.ProductNumber = 234;
            nocco.stockStatus = 14;

            cart.Add(nocco);

            Coffe coffe = new Coffe();
            coffe.roastyness = "Medium roast";
            coffe.ProductNumber = 321;
            coffe.stockStatus = 0;


            cart.Add(coffe);

            foreach (Product product in cart)
            {
                if (product.GetType() == typeof(Milk))
                {
                    Console.WriteLine(((Milk)product).fatContent);
                }         
                
                else if (product.GetType() == typeof(Coffe))
                {
                    Console.WriteLine(((Coffe)product).roastyness);
                }                

                else if (product.GetType() == typeof(Nocco))
                {
                    Console.WriteLine(((Nocco)product).flavor);
                }

            }
        }
    }
}
