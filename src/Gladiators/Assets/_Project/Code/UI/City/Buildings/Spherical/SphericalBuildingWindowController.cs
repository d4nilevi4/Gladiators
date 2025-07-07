using Cysharp.Threading.Tasks;
using Gladiators.Gameplay;

namespace Gladiators.UI.City;

public class SphericalBuildingWindowController : IWindow
{
    private readonly ICityWindowViewFactory _cityWindowViewFactory;
    private readonly IBuildingWindowsController _buildingWindowsController;

    private SphericalBuildingWindowView _view;

    public bool IsWindowOpened => _view;

    public SphericalBuildingWindowController(
        ICityWindowViewFactory cityWindowViewFactory,
        IBuildingWindowsController buildingWindowsController
    )
    {
        _cityWindowViewFactory = cityWindowViewFactory;
        _buildingWindowsController = buildingWindowsController;
    }

    public async UniTask ShowAsync()
    {
        _view = await _cityWindowViewFactory.CreateSphericalWindowView();

        _view.EventCloseButtonPerformed += CloseWindow;
    }

    private void CloseWindow()
    {
        _buildingWindowsController.HandleHide(this).Forget();
    }

    public UniTask HideAsync()
    {
        _view.EventCloseButtonPerformed -= CloseWindow;
        
        _view.DestroyUnityObjectIfExist();
        _view = null;

        return UniTask.CompletedTask;
    }
}