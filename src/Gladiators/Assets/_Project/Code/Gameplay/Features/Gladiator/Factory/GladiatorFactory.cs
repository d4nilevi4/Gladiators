using Gladiators.Common;
using Gladiators.Common.Entity;
using Gladiators.Gameplay.StaticData;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Gladiator;

public class GladiatorFactory : IGladiatorFactory
{
    private readonly IStaticDataProvider _staticDataProvider;
    private readonly IIdentifierService _identifierService;

    public GladiatorFactory(
        IStaticDataProvider staticDataProvider,
        IIdentifierService identifierService
    )
    {
        _staticDataProvider = staticDataProvider;
        _identifierService = identifierService;
    }

    public GameEntity Create(GladiatorTypeId gladiatorTypeId, Vector3 at)
    {
        return CreateEntity.Empty()
                .AddId(_identifierService.Next())
                .AddWorldPosition(at)
                .With(x => x.isGladiator = true)
                .AddViewPrefab(_staticDataProvider.GetGladiatorPrefab(gladiatorTypeId))
                .AddRigidbodyMovementComponents(7f)
            ;
    }
}