using UnityEngine;

namespace Gladiators.Gameplay.Cameras
{
    public class CameraProvider : ICameraProvider
    {
        public Camera MainCamera { get; private set; }
        
        public void SetMainCamera(Camera camera)
        {
            MainCamera = camera;
        }
    }
}