using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace Gladiators.Gameplay.StaticData
{
    public interface IStaticDataProvider
    {
        [MustUseReturnValue]
        UniTask LoadAll();
    }
}