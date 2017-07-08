namespace Factory
{
    public class MeleeGenerator : IHeroGenerator
    {
        private readonly Hero _hero;

        public MeleeGenerator(string name)
        {
            _hero = new Hero(name, HeroType.Melee);
        }

        public Hero GetHero()
        {
            return _hero;
        }
    }
}