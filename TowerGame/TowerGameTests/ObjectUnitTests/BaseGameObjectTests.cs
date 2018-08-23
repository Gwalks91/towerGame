
namespace TowerGameTests.ObjectUnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Microsoft.Xna.Framework;

    using TowerGame.GameObjects;

    [TestClass]
    public class BaseGameObjectTests
    {
        [TestMethod]
        public void CheckThatBaseGameObjectCanBeCreated()
        {
            BaseGameObject testObj = CreateBaseGameObject(Vector2.Zero, 1.0f);
        }

        [TestMethod]
        public void BaseGameObjectCanHaveDestinationSet()
        {
            Vector2 testDestination = new Vector2(20, 10);

            BaseGameObject testObj = CreateBaseGameObject(Vector2.Zero, 1.0f);

            testObj.UpdateDestination(testDestination);

            Assert.AreEqual(testDestination, testObj.Destination);
        }



        public BaseGameObject CreateBaseGameObject(Vector2 Location, float MoveSpeed)
        {
            return new BaseGameObject()
            {
                Location = Location,
                MoveSpeed = MoveSpeed
            };
        }
    }
}
