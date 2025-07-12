namespace Gladiators.Gameplay.Enemies;

public class ChaseGladiatorSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _enemies;
    private readonly IGroup<GameEntity> _gladiators;

    public ChaseGladiatorSystem(GameContext game)
    {
        _enemies = game.GetGroup(GameMatcher
            .AllOf(
                GameMatcher.Enemy,
                GameMatcher.MovementDirection,
                GameMatcher.Transform));

        _gladiators = game.GetGroup(GameMatcher
            .AllOf(
                GameMatcher.Gladiator,
                GameMatcher.Transform));
    }

    public void Execute()
    {
        foreach (GameEntity gladiator in _gladiators)
        foreach (GameEntity enemy in _enemies)
        {
            enemy.isMoving = true;
            
            var direction = (gladiator.Transform.position - enemy.Transform.position).normalized;
            enemy.ReplaceMovementDirection(direction);
        }
    }
}