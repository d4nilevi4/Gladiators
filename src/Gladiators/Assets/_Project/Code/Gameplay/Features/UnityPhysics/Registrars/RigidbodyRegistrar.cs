using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.UnityPhysics
{
    public class RigidbodyRegistrar : EntityComponentRegistrar
    {
        public Rigidbody Rigidbody;
        
        public override void RegisterComponents()
        {
            Entity.AddRigidbody(Rigidbody);
        }

        public override void UnregisterComponents()
        {
            if(Entity.hasRigidbody)
                Entity.RemoveRigidbody();
        }
    }
}