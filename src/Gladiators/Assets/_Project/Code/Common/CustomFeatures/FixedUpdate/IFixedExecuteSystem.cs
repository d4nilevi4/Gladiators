using Entitas;

namespace Gladiators.Common
{
    public interface IFixedExecuteSystem : ISystem
    {
        void FixedExecute();
    }
}