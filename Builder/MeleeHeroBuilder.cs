using System;
namespace Builder
{
    public class MeleeHeroBuilder : IHeroBuilder
    {
        private Hero hero = new Hero();

        public void PutShield()
        {
            hero.Shield = ShieldType.Steel;
        }

        public void PutWeapon()
        {
            hero.Weapon = WeaponType.Sword;
		}

		public Hero Build()
		{
			return hero;
		}
    }
}
