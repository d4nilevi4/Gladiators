using Gladiators.Gameplay.Cameras;
using Gladiators.Gameplay.Environment;
using Gladiators.Gameplay.Levels;
using Gladiators.UI;

namespace Gladiators.Infrastructure
{
    public class CityLevelInitializer : MonoBehaviour
    {
        public Camera MainCamera;
        public CityEnvironmentRoot EnvironmentRoot;
        public Transform UIRoot;
        
        private ICameraProvider _cameraProvider;
        private ICityLevelDataProvider _cityLevelDataProvider;
        private IUIRootProvider _uiRootProvider;

        [Inject]
        private void Construct(
            ICameraProvider cameraProvider,
            ICityLevelDataProvider cityLevelDataProvider,
            IUIRootProvider uiRootProvider
            )
        {
            _uiRootProvider = uiRootProvider;
            _cityLevelDataProvider = cityLevelDataProvider;
            _cameraProvider = cameraProvider;
        }

        private void Awake()
        {
            _cameraProvider.SetMainCamera(MainCamera);
            _cityLevelDataProvider.SetEnvironmentRoot(EnvironmentRoot);
            _uiRootProvider.SetUIRoot(UIRoot);
        }
    }
}