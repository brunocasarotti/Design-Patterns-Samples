namespace FactoryMethod.Heroes
{
    internal interface IHero
    {
        string Weapon { get; }
        void Attack();
        void Block();
    }
}