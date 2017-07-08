using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities
{
    public class RangedVillain : Villain
    {
        public RangedVillain()
        {
            Style = FightingStyle.Ranged;
        }
    }
}