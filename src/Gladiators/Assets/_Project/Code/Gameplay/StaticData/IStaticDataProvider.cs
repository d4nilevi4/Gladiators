using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace Factory.Gameplay.StaticData
{
    public interface IStaticDataProvider
    {
        [MustUseReturnValue]
        UniTask LoadAll();
    }
}