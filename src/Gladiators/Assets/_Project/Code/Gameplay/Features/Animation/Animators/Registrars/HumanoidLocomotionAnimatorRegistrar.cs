using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Animation
{
    public class HumanoidLocomotionAnimatorRegistrar : EntityComponentRegistrar
    {
        public HumanoidLocomotionAnimator Animator;
        
        public override void RegisterComponents()
        {
            Entity.AddHumanoidLocomotionAnimator(Animator);
        }

        public override void UnregisterComponents()
        {
            if (Entity.HumanoidLocomotionAnimator)
                Entity.RemoveHumanoidLocomotionAnimator();
        }
    }
}