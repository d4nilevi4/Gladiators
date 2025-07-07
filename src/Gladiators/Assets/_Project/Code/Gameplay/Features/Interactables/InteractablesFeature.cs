using Gladiators.Common;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Interactables;

public sealed class InteractablesFeature : CustomFeature
{
    public InteractablesFeature(ISystemFactory systemFactory)
    {
        Add(systemFactory.Create<ShowBuildingWindowSystem>());
    }
}