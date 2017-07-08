using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities
{
    public abstract class Hero : Human
    {
        protected Hero()
        {
            Name = GlobalConstant.Hero;
        }
    }
}