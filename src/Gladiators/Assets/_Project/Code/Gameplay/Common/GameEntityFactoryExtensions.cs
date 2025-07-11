using Gladiators.Common;

namespace Gladiators.Gameplay;

public static class GameEntityFactoryExtensions
{
    public static GameEntity AddRigidbodyMovementComponents(this GameEntity entity)
    {
        return entity
                .AddMovementSpeed(7f)
                .AddMovementDirection(default)
                .With(x => x.isRigidbodyMovable = true)
                .With(x => x.isMovementAvailable = true)
            ;
    }
}