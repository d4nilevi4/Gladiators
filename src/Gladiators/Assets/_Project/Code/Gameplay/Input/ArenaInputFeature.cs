using Gladiators.Common;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Input
{
    public sealed class ArenaInputFeature : CustomFeature
    {
        public ArenaInputFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<InitializeLocomotionInputSystem>());
            
            Add(systemFactory.Create<EmitWorldInputSystem>());
            Add(systemFactory.Create<EmitCameraRelativeInputSystem>());
            
            Add(systemFactory.Create<DisableLocomotionInputSystem>());
            
            Add(systemFactory.Create<TearDownInputSystem>());
        }
    }
}