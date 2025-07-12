using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Enemies
{
    [RequireComponent(typeof(EntityBehaviour))]
    public class EnemyTypeIdMarker : MonoBehaviour
    {
        [HideInInspector] public EntityBehaviour EntityBehaviour;
        public EnemyTypeId EnemyTypeId;
    }
}