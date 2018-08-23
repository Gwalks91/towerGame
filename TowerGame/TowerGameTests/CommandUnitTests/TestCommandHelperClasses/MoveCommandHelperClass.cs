
namespace TowerGameTests.TestCommandHelperClasses
{
    using System;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using TowerGame.ObjectInterfaces;

    public class MoveCommandHelperClass : IMovableObject
    {
        public float MoveSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Texture2D Sprite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Vector2 Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Vector2 Destination { get; private set; }

        public void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public void UpdateDestination(Vector2 newDestination)
        {
            this.Destination = newDestination;
        }
    }
}
