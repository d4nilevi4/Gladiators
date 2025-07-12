using Gladiators.Gameplay.Enemies;
using Gladiators.Infrastructure;
using UnityEditor;

namespace Gladiators.Editor
{
    [CustomEditor(typeof(EnemyTypeIdMarker), true)]
    public class EnemyTypeIdMarkerEditor : UnityEditor.Editor
    {
        private void OnEnable()
        {
            var marker = (EnemyTypeIdMarker)target;
            
            if (marker.EntityBehaviour == null)
            {
                marker.EntityBehaviour = marker.GetComponent<EntityBehaviour>();
                EditorUtility.SetDirty(marker);
            }
        }
    }
}