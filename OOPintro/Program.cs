using System;

namespace OOPintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Person emil = new Person("Emil", 18);


            Pet niklas = new Pet();

            niklas._name = "Niklas";
            niklas._species = "Dog";
            niklas._color = "Brown";

            emil._animal = niklas;
                
            emil.Eat();
            emil.Sleep();

            emil._animal.Poop();

        }
    }
}
