﻿using Cysharp.Threading.Tasks;
using Gladiators.Infrastructure;

namespace Gladiators.MainMenu
{
    [RequireComponent(typeof(Button))]
    public class LoadArenaSceneButton : MonoBehaviour
    {
        private IGameStateMachine _gameStateMachine;
        private Button _button;

        [Inject]
        private void Construct(
            IGameStateMachine gameStateMachine
        )
        {
            _gameStateMachine = gameStateMachine;
        }
        
        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnLoadCitySceneButtonPressed);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnLoadCitySceneButtonPressed);
        }

        private void OnLoadCitySceneButtonPressed()
        {
            _gameStateMachine
                .Enter<LoadArenaState>()
                .Forget();
        }
    }
}