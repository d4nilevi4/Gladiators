using Gladiators.Gameplay.Cameras;
using Gladiators.Gameplay.Levels;

namespace Gladiators.Infrastructure
{
    public class LevelInitializer : MonoBehaviour
    {
        public Camera MainCamera;
        
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