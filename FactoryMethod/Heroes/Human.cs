using System;

namespace FactoryMethod.Heroes
{
    internal class Human : IHero
    {
        public Human()
        {
            Console.WriteLine("A human was created!");
        }

        public string Weapon { get; set; }

        public void Attack()
        {
            Console.WriteLine($"Human has attacked! Weapon used: {Weapon}!");
        }

        public void Block()
        {
            Console.WriteLine("Human has blocked an attack.");
        }
    }
}