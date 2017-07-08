namespace Factory
{
    public class Hero
    {
        public Hero(string name, HeroType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }
        public HeroType Type { get; set; }
    }
}