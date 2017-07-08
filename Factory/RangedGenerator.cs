namespace Factory
{
    public class RangedGenerator : IHeroGenerator
    {
        private readonly Hero _hero;

        public RangedGenerator(string name)
        {
            _hero = new Hero(name, HeroType.Ranged);
        }

        public Hero GetHero()
        {
            return _hero;
        }
    }
}