using Xunit;
using Builder;
using Shouldly;
namespace UnitTests
{
    public class BuilderTest
    {
        [Theory]
		[InlineData(WeaponType.Axe, ArmorType.BulletProof, BootType.Leather, ShieldType.Iron)]
        [InlineData(WeaponType.Gun, ArmorType.BulletProof, BootType.Leather, ShieldType.Steel)]
        [InlineData(WeaponType.Sword, ArmorType.BulletProof, BootType.Leather, ShieldType.Iron)]
        [InlineData(WeaponType.Axe, ArmorType.Golden, BootType.Leather, ShieldType.Wooden)]
        [InlineData(WeaponType.Axe, ArmorType.Silver, BootType.Leather, ShieldType.Iron)]
        [InlineData(WeaponType.Axe, ArmorType.BulletProof, BootType.Silk, ShieldType.Iron)]
        [InlineData(WeaponType.Axe, ArmorType.BulletProof, BootType.Skin, ShieldType.Iron)]
        public void HeroBuilderTest(WeaponType weapon, ArmorType armor, BootType boot, ShieldType shield) {

            HeroBuilder builder = new HeroBuilder();
            Hero hero = builder.WithWeapon(weapon).WithArmor(armor).WithBoot(boot).WithShield(shield).Build();

			hero.Weapon.ShouldBe(weapon);
            hero.Armor.ShouldBe(armor);
            hero.Boot.ShouldBe(boot);
            hero.Shield.ShouldBe(shield);
        }

        public void HeroBuilderDirectorTest(){
            
            var heroBuilderDirector = new HeroBuilderDirector();
            var hero = heroBuilderDirector.Construct(new MeleeHeroBuilder());

			hero.Weapon.ShouldBe(WeaponType.Sword);
            hero.Shield.ShouldBe(ShieldType.Steel);
        }
    }
}
