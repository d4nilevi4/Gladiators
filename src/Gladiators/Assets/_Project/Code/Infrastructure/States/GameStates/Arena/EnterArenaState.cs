using Cysharp.Threading.Tasks;
using Gladiators.Common;
using Gladiators.Gameplay.Enemies;
using Gladiators.Gameplay.Gladiator;
using Gladiators.Gameplay.Levels;

namespace Gladiators.Infrastructure
{
    public class EnterArenaState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly IArenaLevelDataProvider _arenaLevelDataProvider;
        private readonly IGladiatorFactory _gladiatorFactory;
        private readonly IEnemyFactory _enemyFactory;

        public EnterArenaState(
            IGameStateMachine stateMachine,
            IArenaLevelDataProvider arenaLevelDataProvider,
            IGladiatorFactory gladiatorFactory,
            IEnemyFactory enemyFactory
        )
        {
            _stateMachine = stateMachine;
            _arenaLevelDataProvider = arenaLevelDataProvider;
            _gladiatorFactory = gladiatorFactory;
            _enemyFactory = enemyFactory;
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

            _enemyFactory.Create(EnemyTypeId.SimpleEnemy, Vector3.zero);
            _enemyFactory.Create(EnemyTypeId.SimpleEnemy, Vector3.zero.SetX(10).SetZ(10));
            _enemyFactory.Create(EnemyTypeId.SimpleEnemy, Vector3.zero.SetX(-10).SetZ(-10));
            _enemyFactory.Create(EnemyTypeId.SimpleEnemy, Vector3.zero.SetX(-10).SetZ(10));
            _enemyFactory.Create(EnemyTypeId.SimpleEnemy, Vector3.zero.SetX(10).SetZ(-10));
        }
    }
}