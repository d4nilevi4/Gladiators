using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace Gladiators.Infrastructure
{
    public interface ISceneLoader
    {
        [MustUseReturnValue]
        UniTask LoadSceneAsync(string name);
    }
}