using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities
{
    public class RangedHero : Hero
    {
        public RangedHero()
        {
            Style = FightingStyle.Ranged;
        }
    }
}