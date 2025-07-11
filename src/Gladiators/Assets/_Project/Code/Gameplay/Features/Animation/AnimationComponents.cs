namespace Gladiators.Gameplay.Animation;

[Game] public class AnimationEvent : IComponent { }
[Game] public class AnimationStateEvent : IComponent { }
[Game] public class AnimationEventName : IComponent { public string Value; }
[Game] public class AnimationHash : IComponent { public int Value; }
[Game] public class AnimatedEntity : IComponent { public int Value; }
[Game] public class HumanoidLocomotionAnimatorComponent : IComponent { public HumanoidLocomotionAnimator Value; }