using Gladiators.Common;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Cameras;

public sealed class ArenaCamerasFeature : CustomFeature
{
    public ArenaCamerasFeature(ISystemFactory systemFactory)
    {
        Add(systemFactory.Create<SetCameraGladiatorLookPointReactiveSystem>());
    }
}