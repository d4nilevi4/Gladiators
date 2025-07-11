using System.Linq;
using Cysharp.Threading.Tasks;
using Gladiators.Gameplay.Gladiator;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.StaticData
{
    public class StaticDataProvider : IStaticDataProvider
    {
        private Dictionary<GladiatorTypeId, EntityBehaviour> _gladiatorsPrefabs = new();

        private readonly IAssetProvider _assetProvider;

        public StaticDataProvider(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public UniTask LoadAll()
        {
            var t1 = LoadGladiators();

            return UniTask.WhenAll(t1);
        }

        public EntityBehaviour GetGladiatorPrefab(GladiatorTypeId typeId)
        {
            return _gladiatorsPrefabs[typeId];
        }
        
        private async UniTask LoadGladiators()
        {
            GladiatorTypeIdMarker[] gladiatorPrefabs =
                await _assetProvider.LoadAll<GladiatorTypeIdMarker>(
                    "Gameplay/Characters/Gladiators");

            _gladiatorsPrefabs = gladiatorPrefabs
                .ToDictionary(
                    key => key.TypeId,
                    value => value.GetComponent<EntityBehaviour>());
        }
    }
}