using Gladiators.Common;

namespace Gladiators.Infrastructure
{
    public sealed class BindViewFeature : CustomFeature
    {
        public BindViewFeature(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<BindEntityFromPathSystem>());
            Add(systemFactory.Create<BindEntityViewFromPrefab>());
        }
    }
}