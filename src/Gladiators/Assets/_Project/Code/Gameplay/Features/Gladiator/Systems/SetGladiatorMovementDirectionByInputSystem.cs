namespace Gladiators.Gameplay.Gladiator;

public class SetGladiatorMovementDirectionByInputSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _gladiators;
    private readonly IGroup<InputEntity> _inputs;

    public SetGladiatorMovementDirectionByInputSystem(GameContext game, InputContext input)
    {
        _gladiators = game.GetGroup(GameMatcher
            .AllOf(
                GameMatcher.Gladiator,
                GameMatcher.MovementDirection));

        _inputs = input.GetGroup(InputMatcher
            .AllOf(
                InputMatcher.Input,
                InputMatcher.CameraRelativeInput));
    }

    public void Execute()
    {
        foreach (InputEntity input in _inputs)
        foreach (GameEntity gladiator in _gladiators)
        {
            gladiator.isMoving = input.hasInputAxis;
            
            if (input.hasInputAxis) 
                gladiator.ReplaceMovementDirection(new Vector3(input.InputAxis.x, 0, input.InputAxis.y));
        }
    }
}