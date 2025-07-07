using Cysharp.Threading.Tasks;
using Gladiators.Gameplay.Buildings;

namespace Gladiators.UI.City;

public class BuildingWindowsController : IBuildingWindowsController
{
    private readonly IWindowFactory _windowFactory;
    public bool CanShowWindow { get; private set; } = true;

    private Dictionary<Type, IWindow> _windows = new ();

    public BuildingWindowsController(
        IWindowFactory windowFactory
    )
    {
        _windowFactory = windowFactory;
    }

    public async UniTask ShowBuildingWindowAsync(BuildingTypeId buildingTypeId)
    {
        switch (buildingTypeId)
        {
            case BuildingTypeId.CubicTest:
                await ShowWindowAsync<CubicBuildingWindowController>();
                break;
            case BuildingTypeId.SphericalTest:
                await ShowWindowAsync<SphericalBuildingWindowController>();
                break;
            case BuildingTypeId.CylindricalTest:
                await ShowWindowAsync<CylindricalBuildingWindowController>();
                break;
            default:
                Debug.Log("Not implemented building window for type: " + buildingTypeId);
                return;
        }
    }

    private UniTask ShowWindowAsync<T>() where T : IWindow
    {
        CanShowWindow = false;
        IWindow window = null;
        
        if (_windows.TryGetValue(typeof(T), out var existingWindow))
        {
            window = existingWindow;
        }
        else
        {
            window = _windowFactory.CreateWindow<T>();
            _windows[typeof(T)] = window;
        }

        return window.ShowAsync();
    }
    
    public UniTask HandleHide(IWindow window)
    {
        CanShowWindow = true;
        return window.HideAsync();
    }
}