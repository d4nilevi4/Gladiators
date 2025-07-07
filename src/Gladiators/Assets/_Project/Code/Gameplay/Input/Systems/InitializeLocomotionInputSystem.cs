using Gladiators.Common;
using Gladiators.Common.Entity;

namespace Gladiators.Gameplay.Input
{
    public class InitializeLocomotionInputSystem : IInitializeSystem
    {
        private readonly ILocomotionInput _locomotionInput;

        public InitializeLocomotionInputSystem(
            ILocomotionInput locomotionInput
        )
        {
            _locomotionInput = locomotionInput;
        }
        
        public void Initialize()
        {
            _locomotionInput.Enable();
            
            CreateInputEntity.Empty()
                .With(x => x.isInput = true)
                .With(x => x.isWorldInput = true);
            
            CreateInputEntity.Empty()
                .With(x => x.isInput = true)
                .With(x => x.isCameraRelativeInput = true);
        }
    }
}