using UnityEngine;

namespace Gladiators.Infrastructure
{
    public class EntityBehaviorProvider : MonoBehaviour, IEntityBehaviorProvider
    {
        [field: SerializeField] public EntityBehaviour EntityBehaviour { get; private set; }
    }
}