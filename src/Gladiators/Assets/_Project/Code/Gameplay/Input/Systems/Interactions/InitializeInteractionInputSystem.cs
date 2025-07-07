using Gladiators.Common;
using Gladiators.Common.Entity;

namespace Gladiators.Gameplay.Input;

public class InitializeInteractionInputSystem : IInitializeSystem
{
    private readonly IInteractionInput _interactionInput;

    public InitializeInteractionInputSystem(
        IInteractionInput interactionInput
    )
    {
        _interactionInput = interactionInput;
    }
    
    public void Initialize()
    {
        _interactionInput.Enable();
        
        CreateInputEntity.Empty()
            .With(x => x.isInput = true)
            .With(x => x.isInteractionInput = true);
    }
}