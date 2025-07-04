using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace Factory.Infrastructure
{
    public interface ISceneLoader
    {
        [MustUseReturnValue]
        UniTask LoadSceneAsync(string name);
    }
}