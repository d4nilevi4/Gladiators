//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherInteractable;

    public static Entitas.IMatcher<GameEntity> Interactable {
        get {
            if (_matcherInteractable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Interactable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInteractable = matcher;
            }

            return _matcherInteractable;
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

    static readonly Gladiators.Gameplay.Interactables.Interactable interactableComponent = new Gladiators.Gameplay.Interactables.Interactable();

    public bool isInteractable {
        get { return HasComponent(GameComponentsLookup.Interactable); }
        set {
            if (value != isInteractable) {
                var index = GameComponentsLookup.Interactable;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : interactableComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
