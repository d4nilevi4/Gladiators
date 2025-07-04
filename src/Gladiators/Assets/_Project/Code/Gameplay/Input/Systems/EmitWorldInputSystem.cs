using Entitas;

namespace Gladiators.Gameplay.Input
{
    public class EmitWorldInputSystem : IExecuteSystem
    {
        private readonly IInputProvider _inputProvider;
        private readonly IGroup<InputEntity> _inputs;

        public EmitWorldInputSystem(
            InputContext input,
            IInputProvider inputProvider)
        {
            _inputProvider = inputProvider;
            
            _inputs = input.GetGroup(InputMatcher
                .AllOf(
                    InputMatcher.Input,
                    InputMatcher.WorldInput));
        }

        public void Execute()
        {
            foreach (InputEntity input in _inputs)
            {
                if (_inputProvider.HasMovementInput)
                    input.ReplaceInputAxis(_inputProvider.GetMovementInputAxis());
                else if (input.hasInputAxis)
                    input.RemoveInputAxis();
            }
        }
    }
}