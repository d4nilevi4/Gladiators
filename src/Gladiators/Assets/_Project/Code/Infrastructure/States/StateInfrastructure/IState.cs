using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace Factory.Infrastructure
{
    public interface IState : IExitableState
    {
        [MustUseReturnValue]
        UniTask Enter();
    }
}