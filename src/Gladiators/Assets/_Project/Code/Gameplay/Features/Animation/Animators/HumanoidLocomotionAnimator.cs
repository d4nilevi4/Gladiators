using static Gladiators.Gameplay.Animation.AnimatorParametersHashes;

namespace Gladiators.Gameplay.Animation
{
    [RequireComponent(typeof(Animator))]
    public class HumanoidLocomotionAnimator : MonoBehaviour
    {
        private Animator _animator;
        private Animator Animator => _animator ??= GetComponent<Animator>();
        
        public void SetIsMoving(bool isMoving)
        {
            Animator.SetBool(IsMoving, isMoving);
        }
        
        public void SetMovement(float x, float z)
        {
            Animator.SetFloat(MovementXHash, x);
            Animator.SetFloat(MovementZHash, z);
        }
        
        public void SetMovement(Vector2 movement)
        {
            Animator.SetFloat(MovementXHash, movement.x);
            Animator.SetFloat(MovementZHash, movement.y);
        }
    }
}