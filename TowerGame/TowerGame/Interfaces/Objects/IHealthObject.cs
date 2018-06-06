namespace TowerGame.ObjectInterfaces
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using TowerGame.MiscClasses;

    public interface IHealthObject
    {
        int Health { get; set; }

        IArmorClass Armor { get; set; }

        void TakeDamage(AttackClass attack);

        void Heal(int amount);

    }
}
