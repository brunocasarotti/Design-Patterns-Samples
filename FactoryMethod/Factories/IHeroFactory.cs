using FactoryMethod.Heroes;

namespace FactoryMethod.Factories
{
    interface IHeroFactory
    {
        IHero CreateHero();
    }
}
