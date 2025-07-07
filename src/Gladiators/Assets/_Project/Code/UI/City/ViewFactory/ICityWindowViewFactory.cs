using System.Threading.Tasks;
using Cysharp.Threading.Tasks;

namespace Gladiators.UI.City;

public interface ICityWindowViewFactory
{
    UniTask<CubicBuildingWindowView> CreateCubicWindowView();
    UniTask<SphericalBuildingWindowView> CreateSphericalWindowView();
    UniTask<CylindricalBuildingWindowView> CreateCylindricalWindowView();
}