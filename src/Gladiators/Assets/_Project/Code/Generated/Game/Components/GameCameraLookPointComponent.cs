//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCameraLookPoint;

    public static Entitas.IMatcher<GameEntity> CameraLookPoint {
        get {
            if (_matcherCameraLookPoint == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CameraLookPoint);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCameraLookPoint = matcher;
            }

            return _matcherCameraLookPoint;
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

    public Gladiators.Gameplay.Cameras.CameraLookPoint cameraLookPoint { get { return (Gladiators.Gameplay.Cameras.CameraLookPoint)GetComponent(GameComponentsLookup.CameraLookPoint); } }
    public UnityEngine.Transform CameraLookPoint { get { return cameraLookPoint.Value; } }
    public bool hasCameraLookPoint { get { return HasComponent(GameComponentsLookup.CameraLookPoint); } }

    public GameEntity AddCameraLookPoint(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.CameraLookPoint;
        var component = (Gladiators.Gameplay.Cameras.CameraLookPoint)CreateComponent(index, typeof(Gladiators.Gameplay.Cameras.CameraLookPoint));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceCameraLookPoint(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.CameraLookPoint;
        var component = (Gladiators.Gameplay.Cameras.CameraLookPoint)CreateComponent(index, typeof(Gladiators.Gameplay.Cameras.CameraLookPoint));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveCameraLookPoint() {
        RemoveComponent(GameComponentsLookup.CameraLookPoint);
        return this;
    }
}
