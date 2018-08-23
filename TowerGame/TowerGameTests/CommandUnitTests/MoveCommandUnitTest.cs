namespace CommandUnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TowerGame.Commands;

    using Microsoft.Xna.Framework;

    using TowerGameTests.TestCommandHelperClasses;

    [TestClass]
    public class MoveCommandUnitTest
    {
        [TestMethod]
        public void TestMoveCommandSetsNewDestination()
        {
            Vector2 startingDestination = new Vector2(5, 5);
            Vector2 newDestination = new Vector2(10, 10);
            MoveCommand testMoveCmd = new MoveCommand(newDestination);

            MoveCommandHelperClass objToMove = new MoveCommandHelperClass();
            objToMove.UpdateDestination(newDestination);

            testMoveCmd.Execute(objToMove);

            Assert.AreEqual(newDestination, objToMove.Destination);
        }

        [TestMethod]
        [ExpectedException(typeof(TypeAccessException),
            "A Type that does not implement IMoveableObject interface was passed to the move command.")]
        public void TestMoveCommandThrowsExceptionOnNonMovableObject()
        {
            Vector2 newDestination = new Vector2(10, 10);
            MoveCommand testMoveCmd = new MoveCommand(newDestination);

            NonMovableCommandHelperClass objToMove = new NonMovableCommandHelperClass();

            testMoveCmd.Execute(objToMove);
        }
    }
}

