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
                InputMatcher.InteractionInput));
    }

    public void Execute()
    {
        foreach (InputEntity input in _inputs)
        {
            if (_interactionInput.IsInteractionPressed())
                input.ReplaceMouseScreenPosition(UnityEngine.Input.mousePosition);
            else if(input.hasMouseScreenPosition)
                input.RemoveMouseScreenPosition();
        }
    }
}