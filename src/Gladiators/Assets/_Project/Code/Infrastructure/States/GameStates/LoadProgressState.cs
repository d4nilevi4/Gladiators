using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Gladiators.Infrastructure
{
    public class LoadProgressState : IState
    {
        private readonly IGameStateMachine _stateMachine;

        public LoadProgressState(IGameStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public async UniTask Enter()
        {
#if LOAD_CURRENT_SCENE && UNITY_EDITOR
            string key = SwitchToEntrySceneInEditor.CURRENT_SCENE_NAME_KEY;
            
            if (PlayerPrefs.HasKey(key))
            {
                string sceneName = PlayerPrefs.GetString(key);
                await _stateMachine.Enter<LoadingBattleState, string>(sceneName);
                PlayerPrefs.DeleteKey(key);
                PlayerPrefs.Save();
                return;
            }
#endif
            await _stateMachine.Enter<LoadingMenuState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;
    }
}