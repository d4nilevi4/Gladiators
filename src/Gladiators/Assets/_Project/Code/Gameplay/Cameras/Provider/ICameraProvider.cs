using UnityEngine;

namespace Factory.Gameplay.Cameras
{
    public interface ICameraProvider
    {
        Camera MainCamera { get; }
        
        void SetMainCamera(Camera camera);
    }
}