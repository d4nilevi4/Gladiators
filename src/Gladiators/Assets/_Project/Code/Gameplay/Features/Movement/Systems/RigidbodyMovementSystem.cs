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
            Vector2 velocity = (movable.MovementSpeed * movable.MovementDirection).SetY(0);
            movable.Rigidbody.linearVelocity = velocity;
        }
    }
}