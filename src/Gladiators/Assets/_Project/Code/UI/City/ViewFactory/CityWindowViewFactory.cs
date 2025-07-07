using Cysharp.Threading.Tasks;
using Gladiators.Infrastructure;

namespace Gladiators.UI.City;

// TODO : Add Dictionary for cashing views
public class CityWindowViewFactory : ICityWindowViewFactory
{
    private readonly IAssetProvider _assetProvider;
    private readonly IUIRootProvider _uiRootProvider;

    public CityWindowViewFactory(
        IAssetProvider assetProvider,
        IUIRootProvider uiRootProvider
    )
    {
        _assetProvider = assetProvider;
        _uiRootProvider = uiRootProvider;
    }

    public async UniTask<CubicBuildingWindowView> CreateCubicWindowView()
    {
        var prefab = await _assetProvider.LoadAsset<CubicBuildingWindowView>(
                "UI/City/Buildings/CubicBuildingWindowView");

        return Object.Instantiate(prefab, _uiRootProvider.UIRoot);
    }

    public async UniTask<SphericalBuildingWindowView> CreateSphericalWindowView()
    {
        var prefab = await _assetProvider.LoadAsset<SphericalBuildingWindowView>(
            "UI/City/Buildings/SphericalBuildingWindowView");

        return Object.Instantiate(prefab, _uiRootProvider.UIRoot);
    }

    public async UniTask<CylindricalBuildingWindowView> CreateCylindricalWindowView()
    {
        var prefab = await _assetProvider.LoadAsset<CylindricalBuildingWindowView>(
            "UI/City/Buildings/CylindricalBuildingWindowView");

        return Object.Instantiate(prefab, _uiRootProvider.UIRoot);
    }
}