using Gladiators.Common;
using Gladiators.Gameplay.Cameras;

namespace Gladiators.Gameplay.Input;

public class InteractableRayCastHitSystem : IExecuteSystem
{
    private readonly IInteractionInput _interactionInput;
    private readonly ICameraProvider _cameraProvider;
    private readonly ICollisionRegistry _collisionRegistry;
    private readonly IGroup<InputEntity> _inputs;
    
    private readonly RaycastHit[] _hits = new RaycastHit[1];
    
    private int ColliderId => _hits[0].collider.GetInstanceID();

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
            int hitsCount = UpdateHits();
            
            if (_interactionInput.IsInteractionPressed() && HasCollides(hitsCount))
                input.ReplaceInteractedColliderId(ColliderId);
            else if (input.hasInteractedColliderId)
                input.RemoveInteractedColliderId();
        }
    }

    private int UpdateHits()
    {
        Vector2 screenPos = UnityEngine.Input.mousePosition;
        
        Ray ray = _cameraProvider.MainCamera.ScreenPointToRay(screenPos);

        return Physics.RaycastNonAlloc(ray, _hits, float.MaxValue, CollisionLayer.Interactable.AsMask());
    }

    private bool HasCollides(int hitCount)
    {
        if (hitCount > 0)
        {
            var hit = _hits[0];
            var colliderId = hit.collider.GetInstanceID();
            var entity = _collisionRegistry.Get<GameEntity>(colliderId);
            return entity != null;
        }

        return false;
    }
}