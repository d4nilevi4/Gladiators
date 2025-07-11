using Cysharp.Threading.Tasks;
using Gladiators.Gameplay.Levels;

namespace Gladiators.Infrastructure
{
    public class EnterCityState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly ICityLevelDataProvider _cityLevelDataProvider;

        public EnterCityState(
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

            await _stateMachine.Enter<CityLoopState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;

        private void PlaceHero()
        {
        }
    }
}