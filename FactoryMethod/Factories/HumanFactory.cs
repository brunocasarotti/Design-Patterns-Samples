using FactoryMethod.Heroes;

namespace FactoryMethod.Factories
{
    class HumanFactory : IHeroFactory
    {
        public IHero CreateHero()
        {
            return new Human { Weapon = "Sword" };
        }
    }
}
