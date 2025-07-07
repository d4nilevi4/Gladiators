namespace Gladiators.UI.City
{
    public class CylindricalBuildingWindowView : MonoBehaviour
    {
        [SerializeField] private Button _closeButton;

        public event Action EventCloseButtonPerformed;

        private void OnEnable()
        {
            _closeButton.onClick.AddListener(OnCloseButtonPerformed);
        }

        private void OnDisable()
        {
            _closeButton.onClick.RemoveListener(OnCloseButtonPerformed);
        }

        private void OnCloseButtonPerformed()
        {
            EventCloseButtonPerformed?.Invoke();
        }
    }
}