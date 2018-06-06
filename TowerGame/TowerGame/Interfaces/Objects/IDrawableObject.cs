namespace TowerGame.ObjectInterfaces
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IDrawableObject : IGameObject
    {
        Texture2D Sprite { get; set; }
        
        Vector2 Location { get; set; }

        void Draw(SpriteBatch spriteBatch);
    }
}
