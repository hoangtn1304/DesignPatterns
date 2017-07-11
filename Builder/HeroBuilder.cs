namespace Builder
{
    public class HeroBuilder
    {
        readonly Hero _hero = new Hero();

        public HeroBuilder WithWeapon(WeaponType weapon)
        {
            _hero.Weapon = weapon;
            return this;
        }

        public HeroBuilder WithShield(ShieldType shield)
        {
            _hero.Shield = shield;
            return this;
        }


        public HeroBuilder WithBoot(BootType boot)
        {
            _hero.Boot = boot;
            return this;
        }

        public HeroBuilder WithArmor(ArmorType armor)
        {
            _hero.Armor = armor;
            return this;
        }

        public Hero Build()
        {
            return _hero;
        }
    }
}
