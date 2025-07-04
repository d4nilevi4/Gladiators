using UnityEngine;

namespace Gladiators.Gameplay.Cameras
{
    public interface ICameraProvider
    {
        Camera MainCamera { get; }
        
        void SetMainCamera(Camera camera);
    }
}