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
#if UNITY_EDITOR
            string key = SwitchToEntrySceneInEditor.CURRENT_SCENE_NAME_KEY;
            
            if (PlayerPrefs.HasKey(key))
            {
                string sceneName = PlayerPrefs.GetString(key);
                
                if (sceneName == Scenes.CITY)
                {
                    await _stateMachine.Enter<LoadCityState>();
                    
                    PlayerPrefs.DeleteKey(key);
                    PlayerPrefs.Save();
                    return;
                }

                if (sceneName == Scenes.ARENA)
                {
                    await _stateMachine.Enter<LoadArenaState>();
                    
                    PlayerPrefs.DeleteKey(key);
                    PlayerPrefs.Save();
                    return;
                }

                PlayerPrefs.DeleteKey(key);
                PlayerPrefs.Save();
            }
#endif
            await _stateMachine.Enter<LoadingMenuState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;
    }
}