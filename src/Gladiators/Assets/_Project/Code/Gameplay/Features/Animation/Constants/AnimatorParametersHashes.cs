namespace Gladiators.Gameplay.Animation;

public static class AnimatorParametersHashes
{
    public static int IsMoving => Animator.StringToHash("IsMoving");
    public static int MovementXHash => Animator.StringToHash("MovementX");
    public static int MovementZHash => Animator.StringToHash("MovementZ");
}