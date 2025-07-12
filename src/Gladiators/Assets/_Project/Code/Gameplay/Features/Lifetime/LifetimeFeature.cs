using Gladiators.Common;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Lifetime;

public sealed class LifetimeFeature : CustomFeature
{
    public LifetimeFeature(ISystemFactory systemFactory)
    {
        Add(systemFactory.Create<MarkDeadSystem>());
    }
}