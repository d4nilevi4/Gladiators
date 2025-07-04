using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace Factory.Infrastructure
{
    public interface IExitableState
    {
        [MustUseReturnValue]
        UniTask Exit();
    }
}