using System;

namespace FactoryMethod.Heroes
{
    internal class Orc : IHero
    {
        public Orc()
        {
            Console.WriteLine("An Orc was created!");
        }

        public string Weapon { get; set; }

        public void Attack()
        {
            Console.WriteLine($"Orc has attacked! Weapon used: {Weapon}!");
        }

        public void Block()
        {
            Console.WriteLine("Orc has blocked an attack.");
        }
    }
}