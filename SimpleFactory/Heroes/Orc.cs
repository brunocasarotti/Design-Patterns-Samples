using System;

namespace SimpleFactory.Heroes
{
    internal class Orc : IHero
    {
        public Orc()
        {
            Console.Write("An Orc was created!");
        }

        public void Attack()
        {
            Console.Write("Orc has attacked!!!");
        }

        public void Block()
        {
            Console.Write("Orc has blocked an attack.");
        }
    }
}