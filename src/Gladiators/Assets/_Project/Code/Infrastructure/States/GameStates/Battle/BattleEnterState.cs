using Cysharp.Threading.Tasks;
using Gladiators.Gameplay.Levels;

namespace Gladiators.Infrastructure
{
    public class BattleEnterState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly ICityLevelDataProvider _cityLevelDataProvider;

        public BattleEnterState(
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

            await _stateMachine.Enter<BattleLoopState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;

        private void PlaceHero()
        {
        }
    }
}