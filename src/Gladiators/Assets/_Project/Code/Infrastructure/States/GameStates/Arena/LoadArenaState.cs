using Cysharp.Threading.Tasks;

namespace Gladiators.Infrastructure
{
    public class LoadArenaState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly ISceneLoader _sceneLoader;

        public LoadArenaState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }

        public async UniTask Enter()
        {
            await _sceneLoader.LoadSceneAsync(Scenes.ARENA);
            await _stateMachine.Enter<EnterArenaState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;
    }
}