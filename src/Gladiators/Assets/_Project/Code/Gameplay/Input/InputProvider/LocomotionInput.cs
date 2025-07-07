namespace Gladiators.Gameplay.Input;

public class LocomotionInput : ILocomotionInput
{
    private readonly IInput _input;

    private PlayerInputActions Input => _input.Input;
    
    public LocomotionInput(
        IInput input
    )
    {
        _input = input;
    }
    
    public void Enable() =>
        Input.Locomotion.Enable();

    public void Disable() =>
        Input.Locomotion.Disable();

    public bool HasMovementInput => GetMovementInputAxis().sqrMagnitude >= 0.01f;
        
    public Vector2 GetMovementInputAxis() => 
        Input.Locomotion.Movement.ReadValue<Vector2>();
}