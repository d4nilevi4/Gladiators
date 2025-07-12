using Gladiators.Common;

namespace Gladiators.Gameplay;

public static class GameEntityFactoryExtensions
{
    public static GameEntity AddRigidbodyMovementComponents(this GameEntity entity, float speed)
    {
        return entity
                .AddMovementSpeed(speed)
                .AddMovementDirection(default)
                .With(x => x.isRigidbodyMovable = true)
                .With(x => x.isMovementAvailable = true)
            ;
    }
}