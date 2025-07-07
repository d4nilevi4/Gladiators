using Cysharp.Threading.Tasks;

namespace Gladiators.Infrastructure
{
    public class CityBattleState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly ISceneLoader _sceneLoader;

        public CityBattleState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }

        public async UniTask Enter()
        {
            await _sceneLoader.LoadSceneAsync(Scenes.CITY);
            await _stateMachine.Enter<CityEnterState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;
    }
}