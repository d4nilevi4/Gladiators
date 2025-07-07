using Gladiators.Common;
using Gladiators.Gameplay;

namespace Gladiators.Infrastructure
{
    public class CityLoopState : EndOfFrameExitState, IFixedUpdatableState
    {
        private readonly ISystemFactory _systems;
        private CityFeature _cityFeature;
        private readonly GameContext _gameContext;
        private readonly IDrawGizmoReceiver _drawGizmoReceiver;

        public CityLoopState(
            ISystemFactory systems, 
            GameContext gameContext,
            IDrawGizmoReceiver drawGizmoReceiver)
        {
            _systems = systems;
            _gameContext = gameContext;
            _drawGizmoReceiver = drawGizmoReceiver;
        }

        protected override void Enter()
        {
            _drawGizmoReceiver.EventDrawGizmo += OnDrawGizmo;
            _cityFeature = _systems.Create<CityFeature>();
            _cityFeature.Initialize();
        }

        protected override void OnUpdate()
        {
            _cityFeature.Execute();
            _cityFeature.Cleanup();
        }

        public void FixedUpdate()
        {
            _cityFeature.FixedExecute();
        }

        protected override void ExitOnEndOfFrame()
        {
            _cityFeature.DeactivateReactiveSystems();
            _cityFeature.ClearReactiveSystems();

            DestructEntities();

            _cityFeature.Cleanup();
            _cityFeature.TearDown();
            _cityFeature = null;
            
            _drawGizmoReceiver.EventDrawGizmo -= OnDrawGizmo;
        }

        private void DestructEntities()
        {
            foreach (GameEntity entity in _gameContext.GetEntities())
                entity.isDestructed = true;
        }

        private void OnDrawGizmo()
        {
            _cityFeature.DrawGizmo();
        }
    }
}