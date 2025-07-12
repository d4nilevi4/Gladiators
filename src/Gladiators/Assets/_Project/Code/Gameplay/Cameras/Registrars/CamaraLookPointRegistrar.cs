using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Cameras
{
    public class CamaraLookPointRegistrar : EntityComponentRegistrar
    {
        public Transform CameraLookPoint;
        
        public override void RegisterComponents()
        {
            Entity.AddCameraLookPoint(CameraLookPoint);
        }

        public override void UnregisterComponents()
        {
            if(Entity.hasCameraLookPoint)
                Entity.RemoveCameraLookPoint();
        }
    }
}