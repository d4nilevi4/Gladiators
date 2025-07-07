namespace Gladiators.Gameplay.Interactables;

public class ShowBuildingWindowSystem : IExecuteSystem
{
    private readonly ICollisionRegistry _collisionRegistry;
    private readonly IGroup<GameEntity> _buildings;
    private readonly IGroup<InputEntity> _inputs;

    public ShowBuildingWindowSystem(
        ICollisionRegistry collisionRegistry, 
        InputContext input,
        GameContext game
        )
    {
        _collisionRegistry = collisionRegistry;
        _inputs = input.GetGroup(InputMatcher
            .AllOf(
                InputMatcher.Input,
                InputMatcher.InteractionInput,
                InputMatcher.InteractedColliderId));

        _buildings = game.GetGroup(GameMatcher
            .AllOf(
                GameMatcher.Interactable,
                GameMatcher.ShowBuildingWindowInteractable,
                GameMatcher.BuildingTypeId));
    }

    public void Execute()
    {
        foreach (InputEntity input in _inputs)
        foreach (GameEntity building in _buildings)
        {
            if(building != _collisionRegistry.Get<GameEntity>(input.InteractedColliderId))
                continue;

            // TODO: Show building window
        }
    }
}