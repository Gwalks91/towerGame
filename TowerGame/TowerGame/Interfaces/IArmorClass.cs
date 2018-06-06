

namespace TowerGame.MiscClasses
{
    using TowerGame.Enums;

    public interface IArmorClass
    {
        int Armor { get; set; }

        ArmorType type { get; set; }

        int CalculateDamage(AttackClass attack);
    }
}
