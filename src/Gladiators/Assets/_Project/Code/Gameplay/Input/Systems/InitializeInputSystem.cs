using Entitas;
using Factory.Common;
using Factory.Common.Entity;

namespace Factory.Gameplay.Input
{
    public class InitializeInputSystem : IInitializeSystem
    {
        public void Initialize()
        {
            CreateInputEntity.Empty()
                .With(x => x.isInput = true)
                .With(x => x.isWorldInput = true);
            
            CreateInputEntity.Empty()
                .With(x => x.isInput = true)
                .With(x => x.isCameraRelativeInput = true);
        }
    }
}