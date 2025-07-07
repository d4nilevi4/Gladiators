namespace Gladiators.Gameplay.Input;

public interface ILocomotionInput
{
    void Enable();
    void Disable();
        
    bool HasMovementInput { get; }
    Vector2 GetMovementInputAxis();
}