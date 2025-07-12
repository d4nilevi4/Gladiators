using Unity.Cinemachine;

namespace Gladiators.Gameplay.Cameras
{
    public interface ICameraProvider
    {
        Camera MainCamera { get; }
        CinemachineCamera LookToGladiatorCamera { get; }
        
        void SetMainCamera(Camera camera);
        void SetLookToGladiatorCamera(CinemachineCamera camera);
    }
}