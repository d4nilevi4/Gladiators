using Cysharp.Threading.Tasks;
using Gladiators.Gameplay.Levels;

namespace Gladiators.Infrastructure
{
    public class EnterArenaState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly ICityLevelDataProvider _cityLevelDataProvider;

        public EnterArenaState(
            IGameStateMachine stateMachine,
            ICityLevelDataProvider cityLevelDataProvider
        )
        {
            _stateMachine = stateMachine;
            _cityLevelDataProvider = cityLevelDataProvider;
        }

        public async UniTask Enter()
        {
            PlaceHero();

            await _stateMachine.Enter<ArenaLoopState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;

        private void PlaceHero()
        {
        }
    }
}