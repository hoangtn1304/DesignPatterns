using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities
{
    public abstract class Villain : Human
    {
        protected Villain()
        {
            Name = GlobalConstant.Villain;
        }
    }
}