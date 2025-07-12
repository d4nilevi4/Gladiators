using Gladiators.Common;
using Gladiators.Common.Destruct;
using Gladiators.Gameplay.Animation;
using Gladiators.Gameplay.Cameras;
using Gladiators.Gameplay.Enemies;
using Gladiators.Gameplay.Gladiator;
using Gladiators.Gameplay.Input;
using Gladiators.Gameplay.Lifetime;
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
        
        Add(systemFactory.Create<ArenaInputFeature>());
        
        Add(systemFactory.Create<LifetimeFeature>());
        
        Add(systemFactory.Create<GladiatorFeature>());
        Add(systemFactory.Create<EnemiesFeature>());
        
        Add(systemFactory.Create<MovementFeature>());
        
        Add(systemFactory.Create<AnimationsFeature>());
        
        Add(systemFactory.Create<ArenaCamerasFeature>());
            
        Add(systemFactory.Create<ProcessDestructedFeature>());
    }
}