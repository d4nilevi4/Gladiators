using Gladiators.Common;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Gladiator;

public sealed class GladiatorFeature : CustomFeature
{
    public GladiatorFeature(ISystemFactory systemFactory)
    {
        Add(systemFactory.Create<SetGladiatorMovementDirectionByInputSystem>());
    }
}