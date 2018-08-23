namespace TowerGameTests.TestCommandHelperClasses
{
    using System;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using TowerGame.ObjectInterfaces;

    public class NonMovableCommandHelperClass : IGameObject
    {
        public NonMovableCommandHelperClass()
        {

        }

        public void Update(GameTime gameTime) 
        {
            throw new NotImplementedException();
        }
    }
}
