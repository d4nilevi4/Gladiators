using Cysharp.Threading.Tasks;
using Factory.Gameplay.Levels;

namespace Factory.Infrastructure
{
    public class BattleEnterState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly ILevelDataProvider _levelDataProvider;

        public BattleEnterState(
            IGameStateMachine stateMachine,
            ILevelDataProvider levelDataProvider
        )
        {
            _stateMachine = stateMachine;
            _levelDataProvider = levelDataProvider;
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