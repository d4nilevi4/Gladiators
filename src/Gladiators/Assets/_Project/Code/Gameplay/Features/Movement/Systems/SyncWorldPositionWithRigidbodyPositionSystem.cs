namespace Gladiators.Gameplay.Movement;

public class SyncWorldPositionWithRigidbodyPositionSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _entities;

    public SyncWorldPositionWithRigidbodyPositionSystem(GameContext game)
    {
        _entities = game.GetGroup(GameMatcher
            .AllOf(
                GameMatcher.Rigidbody,
                GameMatcher.RigidbodyMovable,
                GameMatcher.WorldPosition));
    }

    public void Execute()
    {
        foreach (GameEntity entity in _entities)
        {
            entity.ReplaceWorldPosition(entity.Rigidbody.position);
        }
    }
}