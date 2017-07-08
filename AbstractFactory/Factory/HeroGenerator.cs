using AbstractFactory.Entities;
using AbstractFactory.Entities.Base;
using System;

namespace AbstractFactory.Factory
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public abstract class HeroGenerator
    {
        private static readonly MeleeGenerator MeleeCreator = new MeleeGenerator();
        private static readonly RangedGenerator RangedCreator = new RangedGenerator();

        public static HeroGenerator GetCreator(FightingStyle fightingStyle)
        {
            switch (fightingStyle)
            {
                case FightingStyle.Melee: return MeleeCreator;
                case FightingStyle.Ranged: return RangedCreator;
                default: throw new NotSupportedException(nameof(fightingStyle));
            }
        }

        public abstract Hero CreateHero();
        public abstract Villain CreateVillain();
    }
}