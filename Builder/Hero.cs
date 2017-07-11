using System;
namespace Builder
{
    public class Hero
    {
        public WeaponType Weapon { get; set; }
        public ShieldType Shield { get; set; }
        public BootType Boot { get; set; }
        public ArmorType Armor { get; set; }
    }

    public enum WeaponType {
        Gun,
        Axe,
        Sword
    }

    public enum ShieldType {
        Wooden,
        Iron,
        Steel
    }

    public enum BootType {
        Silk,
        Leather,
        Skin
    }

    public enum ArmorType {
        BulletProof,
        Silver,
        Golden
    }
}
