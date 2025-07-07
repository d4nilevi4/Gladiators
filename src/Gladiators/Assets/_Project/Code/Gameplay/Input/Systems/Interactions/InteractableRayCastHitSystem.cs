using Gladiators.Gameplay.Cameras;

namespace Gladiators.Gameplay.Input;

public class InteractableRayCastHitSystem : IExecuteSystem
{
    private readonly IInteractionInput _interactionInput;
    private readonly ICameraProvider _cameraProvider;
    private readonly ICollisionRegistry _collisionRegistry;
    private readonly IGroup<InputEntity> _inputs;

    public InteractableRayCastHitSystem(
        InputContext input,
        IInteractionInput interactionInput,
        ICameraProvider cameraProvider,
        ICollisionRegistry collisionRegistry)
    {
        _interactionInput = interactionInput;
        _cameraProvider = cameraProvider;
        _collisionRegistry = collisionRegistry;

        _inputs = input.GetGroup(InputMatcher
            .AllOf(
                InputMatcher.Input,
                InputMatcher.InteractionInput));
    }

    public void Execute()
    {
        foreach (InputEntity input in _inputs)
        {
            if (_interactionInput.IsInteractionPressed() && HasCollides(out int colliderId))
                input.ReplaceInteractedColliderId(colliderId);
            else if (input.hasInteractedColliderId)
                input.RemoveInteractedColliderId();
        }
    }

    private bool HasCollides(out int colliderId)
    {
        colliderId = -1;

        Vector2 screenPos = UnityEngine.Input.mousePosition;
        Ray ray = _cameraProvider.MainCamera.ScreenPointToRay(screenPos);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            colliderId = hit.collider.GetInstanceID();
            var entity = _collisionRegistry.Get<GameEntity>(colliderId);

            return entity != null;
        }

        return false;
    }
}