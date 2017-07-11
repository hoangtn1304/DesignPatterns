using System;
namespace Builder
{
    public class RangedHeroBuilder : IHeroBuilder
    {
        private Hero hero = new Hero();

        public void PutShield()
        {
            hero.Shield = ShieldType.Iron;
        }

        public void PutWeapon()
        {
            hero.Weapon = WeaponType.Gun;
        }

        public Hero Build() {
            return hero;
        }
    }
}
