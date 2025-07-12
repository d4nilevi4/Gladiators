using Gladiators.Gameplay.Cameras;
using Gladiators.Gameplay.Levels;
using Gladiators.UI;
using Unity.Cinemachine;

namespace Gladiators.Infrastructure
{
    public class ArenaLevelInitializer : MonoBehaviour
    {
        public Camera MainCamera;
        public CinemachineCamera LookToGladiatorCamera;
        public Transform PlayerSpawnPoint;
        public Transform UIRoot;
        
        private ICameraProvider _cameraProvider;
        private IUIRootProvider _uiRootProvider;
        private IArenaLevelDataProvider _arenaLevelDataProvider;

        [Inject]
        private void Construct(
            ICameraProvider cameraProvider,
            IUIRootProvider uiRootProvider,
            IArenaLevelDataProvider arenaLevelDataProvider
        )
        {
            _arenaLevelDataProvider = arenaLevelDataProvider;
            _uiRootProvider = uiRootProvider;
            _cameraProvider = cameraProvider;
        }

        private void Awake()
        {
            _cameraProvider.SetMainCamera(MainCamera);
            _cameraProvider.SetLookToGladiatorCamera(LookToGladiatorCamera);
            _uiRootProvider.SetUIRoot(UIRoot);
            _arenaLevelDataProvider.SetPlayerSpawnPosition(PlayerSpawnPoint.position);
        }
    }
}