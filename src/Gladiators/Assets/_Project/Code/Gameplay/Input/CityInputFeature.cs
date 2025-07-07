using Gladiators.Common;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Input;

public sealed class CityInputFeature : CustomFeature
{
    public CityInputFeature(ISystemFactory systemFactory)
    {
        Add(systemFactory.Create<InitializeInteractionInputSystem>());
        
        Add(systemFactory.Create<InteractableRayCastHitSystem>());
        
        Add(systemFactory.Create<DisableInteractionInputSystem>());
        Add(systemFactory.Create<TearDownInputSystem>());
    }
}