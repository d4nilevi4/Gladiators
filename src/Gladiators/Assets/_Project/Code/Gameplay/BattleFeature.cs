using Gladiators.Common;
using Gladiators.Gameplay.Input;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay
{
    public class BattleFeature : CustomFeature
    {
        public BattleFeature(
            ISystemFactory systemFactory
        )
        {
            Add(systemFactory.Create<InputFeature>());
            
            Add(systemFactory.Create<BindViewFeature>());
        }
    }
}