using Gladiators.Gameplay.Cameras;
using Gladiators.Gameplay.Levels;
using UnityEngine;
using Zenject;

namespace Gladiators.Infrastructure
{
    public class LevelInitializer : MonoBehaviour
    {
        public Camera MainCamera;
        public Transform PlayerSpawnPoint;
        
        private ICameraProvider _cameraProvider;
        private ILevelDataProvider _levelDataProvider;

        [Inject]
        private void Construct(
            ICameraProvider cameraProvider,
            ILevelDataProvider levelDataProvider
            )
        {
            _levelDataProvider = levelDataProvider;
            _cameraProvider = cameraProvider;
        }

        private void Awake()
        {
            _cameraProvider.SetMainCamera(MainCamera);
        }
    }
}