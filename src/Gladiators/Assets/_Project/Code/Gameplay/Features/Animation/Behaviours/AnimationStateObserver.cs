using Gladiators.Common.Entity;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Animation
{
    [RequireComponent(typeof(Animator))]
    public class AnimationStateObserver : MonoBehaviour
    {
        private IEntityBehaviorProvider _entityBehaviorProvider;

        [Inject]
        private void Construct(IEntityBehaviorProvider entityBehaviorProvider)
        {
            _entityBehaviorProvider = entityBehaviorProvider;
        }
        
        public void EnteredState(int stateHash) =>
            CreateAnimationStateEvent(stateHash);

        public void ExitedState(int stateHash) =>
            CreateAnimationStateEvent(stateHash);

        public void UpdatedState(int stateHash) =>
            CreateAnimationStateEvent(stateHash);

        public void AnimationEnded(int stateHash) =>
            CreateAnimationStateEvent(stateHash);

        private void CreateAnimationStateEvent(int stateHash)
        {
            CreateEntity.Empty()
                .AddAnimatedEntity(_entityBehaviorProvider.EntityBehaviour.Entity.Id)
                .AddAnimationHash(stateHash)
                .isAnimationStateEvent = true;
        }
    }
}