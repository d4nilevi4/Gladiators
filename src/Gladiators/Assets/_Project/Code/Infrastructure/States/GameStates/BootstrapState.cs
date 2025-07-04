using Cysharp.Threading.Tasks;
using Factory.Gameplay.StaticData;

namespace Factory.Infrastructure
{
    public class BootstrapState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly IStaticDataProvider _staticDataProvider;

        public BootstrapState(
            IGameStateMachine stateMachine,
            IStaticDataProvider staticDataProvider)
        {
            _stateMachine = stateMachine;
            _staticDataProvider = staticDataProvider;
        }

        public async UniTask Enter()
        {
            await _staticDataProvider.LoadAll();
            
            await _stateMachine.Enter<LoadProgressState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;
    }
}