using Gladiators.Infrastructure;

namespace Gladiators.Common.Destruct
{
    public class ProcessDestructedFeature : CustomFeature
    {
        public ProcessDestructedFeature(ISystemFactory systems)
        {
            Add(systems.Create<SelfDestructTimerSystem>());

            Add(systems.Create<CleanupGameDestructedViewSystem>());
            
            Add(systems.Create<CleanupGameDestructedSystem>());
            Add(systems.Create<CleanupInputDestructedSystem>());
        }
    }
}