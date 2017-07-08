using AbstractFactory.Entities;

namespace AbstractFactory.Factory
{
    public class RangedGenerator : HeroGenerator
    {
        public override Hero CreateHero()
        {
            return new RangedHero();
        }

        public override Villain CreateVillain()
        {
            return new RangedVillain();
        }
    }
}