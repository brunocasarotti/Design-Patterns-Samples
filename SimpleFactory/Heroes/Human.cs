using System;

namespace SimpleFactory.Heroes
{
    internal class Human : IHero
    {
        public Human()
        {
            Console.Write("A human was created!");
        }
        public void Attack()
        {
            Console.Write("Human has attacked!!!");
        }

        public void Block()
        {
            Console.Write("Human has blocked an attack.");
        }
    }
}