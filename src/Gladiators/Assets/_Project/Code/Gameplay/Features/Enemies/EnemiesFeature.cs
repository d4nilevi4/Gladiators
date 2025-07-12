using Gladiators.Common;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Enemies;

public sealed class EnemiesFeature : CustomFeature
{
    public EnemiesFeature(ISystemFactory systemFactory)
    {
        Add(systemFactory.Create<ChaseGladiatorSystem>());
    }
}