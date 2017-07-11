namespace Builder
{
    public interface IHeroBuilder
    {
        void PutWeapon();
        void PutShield();
        Hero Build();
    }
}
