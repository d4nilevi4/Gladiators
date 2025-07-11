using Gladiators.Common.Entity;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Animation
{
    [RequireComponent(typeof(Animator))]
    public class AnimationsCallbackReceiver : MonoBehaviour
    {
        private IEntityBehaviorProvider _entityBehaviorProvider;

        [Inject]
        private void Construct(IEntityBehaviorProvider entityBehaviorProvider)
        {
            _entityBehaviorProvider = entityBehaviorProvider;
        }
        
        public void OnAnimEvent(string eventName)
        {
            CreateEntity.Empty()
                .AddAnimationEventName(eventName)
                .AddAnimatedEntity(_entityBehaviorProvider.EntityBehaviour.Entity.Id)
                .isAnimationEvent = true;
        }
    }
}