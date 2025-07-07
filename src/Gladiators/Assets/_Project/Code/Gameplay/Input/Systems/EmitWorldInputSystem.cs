using Entitas;

namespace Gladiators.Gameplay.Input
{
    public class EmitWorldInputSystem : IExecuteSystem
    {
        private readonly ILocomotionInput _locomotionInput;
        private readonly IGroup<InputEntity> _inputs;

        public EmitWorldInputSystem(
            InputContext input,
            ILocomotionInput locomotionInput)
        {
            _locomotionInput = locomotionInput;
            
            _inputs = input.GetGroup(InputMatcher
                .AllOf(
                    InputMatcher.Input,
                    InputMatcher.WorldInput));
        }

        public void Execute()
        {
            foreach (InputEntity input in _inputs)
            {
                if (_locomotionInput.HasMovementInput)
                    input.ReplaceInputAxis(_locomotionInput.GetMovementInputAxis());
                else if (input.hasInputAxis)
                    input.RemoveInputAxis();
            }
        }
    }
}