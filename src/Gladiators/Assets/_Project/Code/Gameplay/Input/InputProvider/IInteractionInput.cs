namespace Gladiators.Gameplay.Input;

public interface IInteractionInput
{
    void Enable();
    void Disable();
    bool IsInteractionPressed();
}