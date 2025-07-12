using Gladiators.Common;
using Gladiators.Common.Entity;
using Gladiators.Gameplay.StaticData;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Enemies;

public class EnemyFactory : IEnemyFactory
{
    private readonly IIdentifierService _identifierService;
    private readonly IStaticDataProvider _staticDataProvider;

    public EnemyFactory(
        IIdentifierService identifierService,
        IStaticDataProvider staticDataProvider
    )
    {
        _identifierService = identifierService;
        _staticDataProvider = staticDataProvider;
    }
    
    public GameEntity Create(EnemyTypeId enemyTypeId, Vector3 at)
    {
        return CreateEntity.Empty()
                .AddId(_identifierService.Next())
                .AddWorldPosition(at)
                .With(x => x.isEnemy = true)
                .AddViewPrefab(_staticDataProvider.GetEnemyPrefab(enemyTypeId))
                .AddRigidbodyMovementComponents(4f)
            ;
    }
}