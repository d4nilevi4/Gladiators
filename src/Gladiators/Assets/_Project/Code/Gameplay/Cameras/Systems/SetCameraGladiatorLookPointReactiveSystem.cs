namespace Gladiators.Gameplay.Cameras;

public class SetCameraGladiatorLookPointReactiveSystem : ReactiveSystem<GameEntity>
{
    private readonly ICameraProvider _cameraProvider;

    public SetCameraGladiatorLookPointReactiveSystem(GameContext game, ICameraProvider cameraProvider) : base(game)
    {
        _cameraProvider = cameraProvider;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
        context.CreateCollector(GameMatcher.AllOf(GameMatcher.Gladiator, GameMatcher.CameraLookPoint).Added());

    protected override bool Filter(GameEntity lookPoint) => lookPoint.hasCameraLookPoint && lookPoint.isGladiator;

    protected override void Execute(List<GameEntity> lookPoints)
    {
        foreach (GameEntity lookPoint in lookPoints)
        {
            _cameraProvider.LookToGladiatorCamera.Follow = lookPoint.CameraLookPoint;
        }
    }
}