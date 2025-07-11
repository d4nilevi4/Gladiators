using Cysharp.Threading.Tasks;
using Gladiators.Gameplay.Gladiator;
using Gladiators.Infrastructure;
using JetBrains.Annotations;

namespace Gladiators.Gameplay.StaticData
{
    public interface IStaticDataProvider
    {
        [MustUseReturnValue]
        UniTask LoadAll();

        EntityBehaviour GetGladiatorPrefab(GladiatorTypeId typeId);
    }
}