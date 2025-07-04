using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Entitas;

namespace Factory.Infrastructure
{
    public class BindEntityFromPathSystem : IExecuteSystem
    {
        private readonly IEntityViewFactory _entityViewFactory;
        private readonly IGroup<GameEntity> _entities;
        private List<GameEntity> _buffer = new(32);

        public BindEntityFromPathSystem(GameContext game, IEntityViewFactory entityViewFactory)
        {
            _entityViewFactory = entityViewFactory;
            _entities = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.ViewPath)
                .NoneOf(GameMatcher.View));
        }

        public void Execute()
        {
            foreach (GameEntity entity in _entities.GetEntities(_buffer))
            {
                _entityViewFactory.CreateViewForEntity(entity).Forget();
            }
        }
    }
}