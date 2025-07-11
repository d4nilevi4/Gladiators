//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMaxHp;

    public static Entitas.IMatcher<GameEntity> MaxHp {
        get {
            if (_matcherMaxHp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MaxHp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMaxHp = matcher;
            }

            return _matcherMaxHp;
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

    public Gladiators.Gameplay.Lifetime.MaxHp maxHp { get { return (Gladiators.Gameplay.Lifetime.MaxHp)GetComponent(GameComponentsLookup.MaxHp); } }
    public float MaxHp { get { return maxHp.Value; } }
    public bool hasMaxHp { get { return HasComponent(GameComponentsLookup.MaxHp); } }

    public GameEntity AddMaxHp(float newValue) {
        var index = GameComponentsLookup.MaxHp;
        var component = (Gladiators.Gameplay.Lifetime.MaxHp)CreateComponent(index, typeof(Gladiators.Gameplay.Lifetime.MaxHp));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceMaxHp(float newValue) {
        var index = GameComponentsLookup.MaxHp;
        var component = (Gladiators.Gameplay.Lifetime.MaxHp)CreateComponent(index, typeof(Gladiators.Gameplay.Lifetime.MaxHp));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveMaxHp() {
        RemoveComponent(GameComponentsLookup.MaxHp);
        return this;
    }
}
