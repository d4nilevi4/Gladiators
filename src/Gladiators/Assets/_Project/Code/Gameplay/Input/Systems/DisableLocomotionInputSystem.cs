namespace Gladiators.Gameplay.Input;

public class DisableLocomotionInputSystem : ITearDownSystem
{
    private readonly ILocomotionInput _locomotionInput;

    public DisableLocomotionInputSystem(ILocomotionInput locomotionInput)
    {
        _locomotionInput = locomotionInput;
    }
        
    public void TearDown()
    {
        _locomotionInput.Disable();
    }
}