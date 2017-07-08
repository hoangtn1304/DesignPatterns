using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities
{
    public class MeleeHero : Hero
    {
        public MeleeHero()
        {
            Style = FightingStyle.Melee;
        }
    }
}