using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace Gladiators.Infrastructure
{
    public interface IExitableState
    {
        [MustUseReturnValue]
        UniTask Exit();
    }
}