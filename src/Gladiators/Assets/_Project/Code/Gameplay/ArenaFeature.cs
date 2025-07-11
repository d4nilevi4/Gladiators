using Gladiators.Common;
using Gladiators.Common.Destruct;
using Gladiators.Gameplay.Input;
using Gladiators.Gameplay.Interactables;
using Gladiators.Gameplay.Movement;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay;

public class ArenaFeature : CustomFeature
{
    public ArenaFeature(
        ISystemFactory systemFactory
    )
    {
        Add(systemFactory.Create<BindViewFeature>());
        
        Add(systemFactory.Create<MovementFeature>());
            
        Add(systemFactory.Create<ProcessDestructedFeature>());
    }
}