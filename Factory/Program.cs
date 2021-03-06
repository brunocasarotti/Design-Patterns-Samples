﻿namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroToCreate = args[0];

            IHero hero = GetHero(heroToCreate);
            
        }

        private static IHero GetHero(string heroToCreate)
        {
            switch (heroToCreate)
            {
                case nameof(Orc):
                    return new Orc();
                case nameof(Human):
                default:
                    return new Human();
                
            }
        }
    }
}
