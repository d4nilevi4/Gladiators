namespace Gladiators.Gameplay.Input;

public class EmitInteractionInputSystem : IExecuteSystem
{
    private readonly IInteractionInput _interactionInput;
    private readonly IGroup<InputEntity> _inputs;

    public EmitInteractionInputSystem(
        InputContext input,
        IInteractionInput interactionInput)
    {
        _interactionInput = interactionInput;
            
        _inputs = input.GetGroup(InputMatcher
            .AllOf(
                InputMatcher.Input,
                InputMatcher.WorldInput));
    }

    public void Execute()
    {
        foreach (InputEntity input in _inputs)
        {
            // if (_interactionInput.IsInteractionPressed())
                // input.ReplaceInputAxis(_locomotionInput.GetMovementInputAxis());
            // else if (input.hasInputAxis)
                // input.RemoveInputAxis();
        }
    }
}