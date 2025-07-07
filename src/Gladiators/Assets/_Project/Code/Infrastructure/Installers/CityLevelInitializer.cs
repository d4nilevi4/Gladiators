using Gladiators.Gameplay.Cameras;
using Gladiators.Gameplay.Environment;
using Gladiators.Gameplay.Levels;

namespace Gladiators.Infrastructure
{
    public class CityLevelInitializer : MonoBehaviour
    {
        public Camera MainCamera;
        public CityEnvironmentRoot EnvironmentRoot;
        
        private ICameraProvider _cameraProvider;
        private ICityLevelDataProvider _cityLevelDataProvider;

        [Inject]
        private void Construct(
            ICameraProvider cameraProvider,
            ICityLevelDataProvider cityLevelDataProvider
            )
        {
            _cityLevelDataProvider = cityLevelDataProvider;
            _cameraProvider = cameraProvider;
        }

        private void Awake()
        {
            _cameraProvider.SetMainCamera(MainCamera);
            _cityLevelDataProvider.SetEnvironmentRoot(EnvironmentRoot);
        }
    }
}