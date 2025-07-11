using Cysharp.Threading.Tasks;
using Gladiators.Gameplay.Gladiator;
using Gladiators.Gameplay.Levels;

namespace Gladiators.Infrastructure
{
    public class EnterArenaState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly IArenaLevelDataProvider _arenaLevelDataProvider;
        private readonly IGladiatorFactory _gladiatorFactory;

        public EnterArenaState(
            IGameStateMachine stateMachine,
            IArenaLevelDataProvider arenaLevelDataProvider,
            IGladiatorFactory gladiatorFactory
        )
        {
            _stateMachine = stateMachine;
            _arenaLevelDataProvider = arenaLevelDataProvider;
            _gladiatorFactory = gladiatorFactory;
        }

        public async UniTask Enter()
        {
            PlaceGladiator();

            await _stateMachine.Enter<ArenaLoopState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;

        private void PlaceGladiator()
        {
            _gladiatorFactory.Create(GladiatorTypeId.SimpleGladiator,
                _arenaLevelDataProvider.PlayerSpawnPosition);
        }
    }
}