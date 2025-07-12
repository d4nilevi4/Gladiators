using System.Linq;
using Cysharp.Threading.Tasks;
using Gladiators.Gameplay.Enemies;
using Gladiators.Gameplay.Gladiator;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.StaticData
{
    public class StaticDataProvider : IStaticDataProvider
    {
        private Dictionary<GladiatorTypeId, EntityBehaviour> _gladiatorsPrefabs;
        private Dictionary<EnemyTypeId, EntityBehaviour> _enemiesPrefabs;

        private readonly IAssetProvider _assetProvider;

        public StaticDataProvider(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public UniTask LoadAll()
        {
            var t1 = LoadGladiators();
            var t2 = LoadEnemies();

            return UniTask.WhenAll(t1, t2);
        }

        public EntityBehaviour GetGladiatorPrefab(GladiatorTypeId typeId)
        {
            return _gladiatorsPrefabs[typeId];
        }

        public EntityBehaviour GetEnemyPrefab(EnemyTypeId typeId)
        {
            return _enemiesPrefabs[typeId];
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
        
        private async UniTask LoadEnemies()
        {
            EnemyTypeIdMarker[] enemiesPrefabs =
                await _assetProvider.LoadAll<EnemyTypeIdMarker>(
                    "Gameplay/Characters/Enemies");

            _enemiesPrefabs = enemiesPrefabs
                .ToDictionary(
                    key => key.EnemyTypeId,
                    value => value.EntityBehaviour);
        }
    }
}