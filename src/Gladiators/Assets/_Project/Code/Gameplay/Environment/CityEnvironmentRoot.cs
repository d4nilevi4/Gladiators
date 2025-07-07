namespace Gladiators.Gameplay.Environment
{
    public class CityEnvironmentRoot : MonoBehaviour, ICityEnvironmentRoot
    {
        [field: SerializeField] public Transform EnvironmentRoot { get; private set; }
        [field: SerializeField] public Transform GroundRoot { get; private set; }
        [field: SerializeField] public Transform BuildingsRoot { get; private set; }
    }
}