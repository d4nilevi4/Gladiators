using Gladiators.Common;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Animation;

public sealed class AnimationsFeature : CustomFeature
{
    public AnimationsFeature(ISystemFactory systemFactory)
    {
        Add(systemFactory.Create<AnimationEventsCleanupSystem>());
        Add(systemFactory.Create<AnimationStateEventsCleanupSystem>());
    }
}