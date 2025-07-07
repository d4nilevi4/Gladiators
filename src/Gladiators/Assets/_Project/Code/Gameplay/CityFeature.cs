using Gladiators.Common;
using Gladiators.Gameplay.Input;
using Gladiators.Gameplay.Interactables;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay
{
    public class CityFeature : CustomFeature
    {
        public CityFeature(
            ISystemFactory systemFactory
        )
        {
            Add(systemFactory.Create<CityInputFeature>());
            
            Add(systemFactory.Create<InteractablesFeature>());
            
            Add(systemFactory.Create<BindViewFeature>());
        }
    }
}