namespace Gladiators.Gameplay.Animation;

public class AnimateHumanoidLocomotionMovementSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _entities;

    public AnimateHumanoidLocomotionMovementSystem(GameContext game)
    {
        _entities = game.GetGroup(GameMatcher
            .AllOf(
                GameMatcher.HumanoidLocomotionAnimator,
                GameMatcher.MovementDirection,
                GameMatcher.Transform));
    }

    public void Execute()
    {
        foreach (GameEntity entity in _entities)
        {
            entity.HumanoidLocomotionAnimator.SetIsMoving(entity.isMoving);
            entity.HumanoidLocomotionAnimator.SetMovement(MoveAxis(entity));
        }
    }
    
    private Vector2 MoveAxis(GameEntity entity)
    {
        Vector3 flatVelocity = entity.MovementDirection;
            
        Vector3 forward = entity.Transform.forward;
        Vector3 right = entity.Transform.right;
            
        forward.y = 0;
        right.y = 0;
            
        forward.Normalize();
        right.Normalize();

        float forwardAmount = Vector3.Dot(flatVelocity.normalized, forward);
        float rightAmount = Vector3.Dot(flatVelocity.normalized, right);

        return new Vector2(rightAmount, forwardAmount);
    }
}