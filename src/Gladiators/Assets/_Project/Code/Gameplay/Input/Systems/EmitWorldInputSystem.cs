using Entitas;

namespace Factory.Gameplay.Input
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
                if (_inputProvider.HasAxisInput)
                    input.ReplaceInputAxis(_inputProvider.GetInputAxis());
                else if (input.hasInputAxis)
                    input.RemoveInputAxis();
            }
        }
    }
}