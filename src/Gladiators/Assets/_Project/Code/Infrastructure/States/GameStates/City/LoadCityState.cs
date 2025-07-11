using Cysharp.Threading.Tasks;

namespace Gladiators.Infrastructure
{
    public class LoadCityState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly ISceneLoader _sceneLoader;

        public LoadCityState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }

        public async UniTask Enter()
        {
            await _sceneLoader.LoadSceneAsync(Scenes.CITY);
            await _stateMachine.Enter<EnterCityState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;
    }
}