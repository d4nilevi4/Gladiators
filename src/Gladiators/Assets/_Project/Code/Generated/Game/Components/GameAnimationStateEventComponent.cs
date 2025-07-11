//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnimationStateEvent;

    public static Entitas.IMatcher<GameEntity> AnimationStateEvent {
        get {
            if (_matcherAnimationStateEvent == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnimationStateEvent);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnimationStateEvent = matcher;
            }

            return _matcherAnimationStateEvent;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Gladiators.Gameplay.Animation.AnimationStateEvent animationStateEventComponent = new Gladiators.Gameplay.Animation.AnimationStateEvent();

    public bool isAnimationStateEvent {
        get { return HasComponent(GameComponentsLookup.AnimationStateEvent); }
        set {
            if (value != isAnimationStateEvent) {
                var index = GameComponentsLookup.AnimationStateEvent;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : animationStateEventComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
