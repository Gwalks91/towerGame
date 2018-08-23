

namespace TowerGame.Interfaces
{
    using TowerGame.ObjectInterfaces;

    public interface ICommand
    {
        void Execute(IGameObject objToExecuteOn);
    }
}
