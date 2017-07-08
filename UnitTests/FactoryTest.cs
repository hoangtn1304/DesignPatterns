using System;
using Factory;
using Shouldly;
using Xunit;

namespace UnitTests
{
    public class FactoryTest
    {
        [Theory]
        [InlineData("Alex")]
        [InlineData("Ferguson")]
        [InlineData("Chau Tinh Tri")]
        public void HeroGeneratorTest(string name)
        {
            var seed = new Random().Next(0, 10) % 2;

            var generator = seed == 0
                ? new MeleeGenerator(name) as IHeroGenerator
                : new RangedGenerator(name);

            generator.ShouldNotBeNull();
            var hero = generator.GetHero();
            hero.Name.ShouldBe(name);
        }
    }
}