using AbstractFactory;
using AbstractFactory.Entities.Base;
using AbstractFactory.Factory;
using Shouldly;
using Xunit;

namespace UnitTests
{
    public class AbstractFactoryTest
    {
        [Theory]
        [InlineData(FightingStyle.Melee)]
        [InlineData(FightingStyle.Ranged)]
        public void HeroTest(FightingStyle style)
        {
            var generator = HeroGenerator.GetCreator(style);
            var hero = generator.CreateHero();

            hero.Name.ShouldBe(GlobalConstant.Hero);
            hero.Style.ShouldBe(style);
        }

        [Theory]
        [InlineData(FightingStyle.Melee)]
        [InlineData(FightingStyle.Ranged)]
        public void VillainTest(FightingStyle style)
        {
            var generator = HeroGenerator.GetCreator(style);
            var villain = generator.CreateVillain();

            villain.Name.ShouldBe(GlobalConstant.Villain);
            villain.Style.ShouldBe(style);
        }
    }
}