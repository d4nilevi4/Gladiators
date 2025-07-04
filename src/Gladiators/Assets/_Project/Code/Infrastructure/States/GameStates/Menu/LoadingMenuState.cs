using Cysharp.Threading.Tasks;

namespace Factory.Infrastructure
{
    public class LoadingMenuState : IState
    {
        private readonly ISceneLoader _sceneLoader;
        private readonly IGameStateMachine _stateMachine;

        public LoadingMenuState(
            ISceneLoader sceneLoader,
            IGameStateMachine stateMachine
        )
        {
            _sceneLoader = sceneLoader;
            _stateMachine = stateMachine;
        }
        
        public async UniTask Enter()
        {
            await _sceneLoader.LoadSceneAsync(Scenes.MAIN_MENU);
            await _stateMachine.Enter<MenuLoopState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;
    }
}