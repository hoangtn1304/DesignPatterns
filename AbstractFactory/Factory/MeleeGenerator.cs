using AbstractFactory.Entities;

namespace AbstractFactory.Factory
{
    public class MeleeGenerator : HeroGenerator
    {
        public override Hero CreateHero()
        {
            return new MeleeHero();
        }

        public override Villain CreateVillain()
        {
            return new MeleeVillain();
        }
    }
}