namespace Gladiators.Gameplay.Input;

public class DisableInteractionInputSystem : ITearDownSystem
{
    private readonly IInteractionInput _interactionInput;

    public DisableInteractionInputSystem(
        IInteractionInput interactionInput
    )
    {
        _interactionInput = interactionInput;
    }
    
    public void TearDown()
    {
        _interactionInput.Disable();
    }
}
