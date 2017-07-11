using System;
namespace Builder
{
    public class HeroBuilderDirector
    {
        public Hero Construct(IHeroBuilder builder) {
            
            builder.PutShield();
            builder.PutWeapon();

            return builder.Build();
        }
    }
}
