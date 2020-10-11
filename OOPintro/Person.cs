using System;

namespace OOPintro
{
    class Person
    {
        private string _name;

        private int _age;

        private Pet _animal;


        public Person(string name, int age, Pet animal)
        {
            _name = name;
            _age = age;
            _animal = animal;
        }

        public void Eat()
        {
            Console.WriteLine(_name + " is eating!");
        }

        public void Sleep()
        {
            Console.WriteLine(_name + " is sleeping!");
        }

        public static void SayName(Person person)
        {
            Console.WriteLine(Person._name);
        }
    }
}
