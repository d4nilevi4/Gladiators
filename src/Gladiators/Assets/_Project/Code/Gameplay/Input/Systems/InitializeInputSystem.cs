using Entitas;
using Gladiators.Common;
using Gladiators.Common.Entity;

namespace Gladiators.Gameplay.Input
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