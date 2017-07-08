using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities
{
    public class MeleeVillain : Villain
    {
        public MeleeVillain()
        {
            Style = FightingStyle.Melee;
        }
    }
}