using Gladiators.Common;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Movement;

public sealed class MovementFeature : CustomFeature
{
    public MovementFeature(ISystemFactory systemFactory)
    {
        Add(systemFactory.Create<RigidbodyMovementSystem>());
        
        Add(systemFactory.Create<SyncWorldPositionWithRigidbodyPositionSystem>());
    }
}