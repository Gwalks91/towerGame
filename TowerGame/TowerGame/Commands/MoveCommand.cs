namespace TowerGame.Commands
{
    using System;
    using TowerGame.Interfaces;
    using TowerGame.ObjectInterfaces;
    using Microsoft.Xna.Framework;
    

    public class MoveCommand : ICommand
    {
        private Vector2 destination;

        public MoveCommand(Vector2 destination)
        {
            this.destination = destination;
        }

        public void Execute(IGameObject objToExecuteOn)
        {
            IMovableObject movableObject = objToExecuteOn as IMovableObject;
            if (movableObject == null)
            {
                throw new TypeAccessException();
            }
            movableObject.UpdateDestination(this.destination);
        }
    }
}
