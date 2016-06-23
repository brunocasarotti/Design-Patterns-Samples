using FactoryMethod.Heroes;

namespace FactoryMethod.Factories
{
    class OrcFactory : IHeroFactory
    {
        public IHero CreateHero()
        {
            return new Orc { Weapon = "Axe" };
        }
    }
}
