using Gladiators.Common;
using Gladiators.Gameplay;

namespace Gladiators.Infrastructure
{
    public class ArenaLoopState : EndOfFrameExitState, IFixedUpdatableState
    {
        private readonly ISystemFactory _systems;
        private ArenaFeature _arenaFeature;
        private readonly GameContext _gameContext;
        private readonly IDrawGizmoReceiver _drawGizmoReceiver;

        public ArenaLoopState(
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
            _arenaFeature = _systems.Create<ArenaFeature>();
            _arenaFeature.Initialize();
        }

        protected override void OnUpdate()
        {
            _arenaFeature.Execute();
            _arenaFeature.Cleanup();
        }

        public void FixedUpdate()
        {
            _arenaFeature.FixedExecute();
        }

        protected override void ExitOnEndOfFrame()
        {
            _arenaFeature.DeactivateReactiveSystems();
            _arenaFeature.ClearReactiveSystems();

            DestructEntities();

            _arenaFeature.Cleanup();
            _arenaFeature.TearDown();
            _arenaFeature = null;
            
            _drawGizmoReceiver.EventDrawGizmo -= OnDrawGizmo;
        }

        private void DestructEntities()
        {
            foreach (GameEntity entity in _gameContext.GetEntities())
                entity.isDestructed = true;
        }

        private void OnDrawGizmo()
        {
            _arenaFeature.DrawGizmo();
        }
    }
}