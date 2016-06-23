using FactoryMethod.Factories;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IHeroFactory fac = LoadFactory();
            var hero = fac.CreateHero();
            hero.Attack();
            Console.ReadKey();
        }

        private static IHeroFactory LoadFactory()
        {
            //This is just a load method, this configuration can come from an IoC
            //or may be stored in some database or file. It's up to you to load the
            //factories that you want.

            return new HumanFactory();
        }
    }
}
