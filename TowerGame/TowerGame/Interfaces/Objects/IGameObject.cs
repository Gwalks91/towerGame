namespace TowerGame.ObjectInterfaces
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IGameObject
    {
        void Update(GameTime gameTime);
    }
}
