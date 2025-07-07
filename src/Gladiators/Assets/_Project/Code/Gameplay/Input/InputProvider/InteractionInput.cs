namespace Gladiators.Gameplay.Input;

public class InteractionInput : IInteractionInput
{
    private readonly IInput _input;

    private PlayerInputActions Input => _input.Input;
    
    public InteractionInput(
        IInput input
    )
    {
        _input = input;
    }

    public void Enable() =>
        Input.Interactions.Interaction.Enable();

    public void Disable() =>
        Input.Interactions.Interaction.Disable();

    public bool IsInteractionPressed() => 
        Input.Interactions.Interaction.IsPressed();
}