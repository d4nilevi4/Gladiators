using Factory.Common;
using Factory.Gameplay.Input;
using Factory.Infrastructure;

namespace Factory.Gameplay
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