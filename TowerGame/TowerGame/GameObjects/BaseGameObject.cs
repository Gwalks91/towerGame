namespace TowerGame.GameObjects
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using TowerGame.ObjectInterfaces;

    public class BaseGameObject : IMovableObject
    {
        public float MoveSpeed { get; set; }

        public Vector2 Destination { get; private set; }

        public Texture2D Sprite { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Vector2 Location { get; set; }

        public BaseGameObject()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateDestination(Vector2 newDestination)
        {
            this.Destination = newDestination;
        }
    }
}
