using Gladiators.Common;

namespace Gladiators.Gameplay.Movement;

public class RigidbodyMovementSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _movables;

    public RigidbodyMovementSystem(GameContext game)
    {
        _movables = game.GetGroup(GameMatcher
            .AllOf(
                GameMatcher.RigidbodyMovable,
                GameMatcher.MovementAvailable,
                GameMatcher.MovementSpeed,
                GameMatcher.Rigidbody,
                GameMatcher.MovementDirection));
    }

    public void Execute()
    {
        foreach (GameEntity movable in _movables)
        {
            Vector3 movableMovementDirection = movable.isMoving
                ? (movable.MovementSpeed * movable.MovementDirection)
                : Vector3.zero;
            
            Vector3 velocity = movableMovementDirection.SetY(movable.Rigidbody.linearVelocity.y);
            
            movable.Rigidbody.linearVelocity = velocity;
        }
    }
}