using Gladiators.Common;
using Gladiators.Gameplay.Input;
using Gladiators.Gameplay.Interactables;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay;

public class ArenaFeature : CustomFeature
{
    public ArenaFeature(
        ISystemFactory systemFactory
    )
    {
        Add(systemFactory.Create<ArenaFeature>());
            
        Add(systemFactory.Create<BindViewFeature>());
    }
}