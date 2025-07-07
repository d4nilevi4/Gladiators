using Cysharp.Threading.Tasks;
using Gladiators.Gameplay;

namespace Gladiators.UI.City;

public class CubicBuildingWindowController : IWindow
{
    private readonly ICityWindowViewFactory _cityWindowViewFactory;
    private readonly IBuildingWindowsController _buildingWindowsController;

    private CubicBuildingWindowView _cubicBuildingWindowView;

    public bool IsWindowOpened => _cubicBuildingWindowView;

    public CubicBuildingWindowController(
        ICityWindowViewFactory cityWindowViewFactory,
        IBuildingWindowsController buildingWindowsController
    )
    {
        _cityWindowViewFactory = cityWindowViewFactory;
        _buildingWindowsController = buildingWindowsController;
    }

    public async UniTask ShowAsync()
    {
        _cubicBuildingWindowView = await _cityWindowViewFactory.CreateCubicWindowView();

        _cubicBuildingWindowView.EventCloseButtonPerformed += CloseWindow;
    }

    private void CloseWindow()
    {
        _buildingWindowsController.HandleHide(this).Forget();
    }

    public UniTask HideAsync()
    {
        _cubicBuildingWindowView.EventCloseButtonPerformed -= CloseWindow;
        
        _cubicBuildingWindowView.DestroyUnityObjectIfExist();
        _cubicBuildingWindowView = null;

        return UniTask.CompletedTask;
    }
}