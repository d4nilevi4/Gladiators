using Entitas;
using UnityEngine;

namespace Gladiators.Common.Destruct
{
    public class CleanupGameDestructedViewSystem : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public CleanupGameDestructedViewSystem(GameContext game) => 
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Destructed,
                    GameMatcher.View));

        public void Cleanup()
        {
            foreach (GameEntity entity in _entities)
            {
                entity.View.ReleaseEntity();
                Object.Destroy(entity.View.gameObject);
            }
        }
    }
}