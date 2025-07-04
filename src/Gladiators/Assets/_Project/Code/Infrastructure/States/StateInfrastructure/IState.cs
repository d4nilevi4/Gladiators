using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace Gladiators.Infrastructure
{
    public interface IState : IExitableState
    {
        [MustUseReturnValue]
        UniTask Enter();
    }
}