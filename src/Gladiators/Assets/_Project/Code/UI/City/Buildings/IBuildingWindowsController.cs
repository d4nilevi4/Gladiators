using Cysharp.Threading.Tasks;
using Gladiators.Gameplay.Buildings;
using JetBrains.Annotations;

namespace Gladiators.UI.City;

public interface IBuildingWindowsController
{
    bool CanShowWindow { get; }
    [MustUseReturnValue]
    UniTask ShowBuildingWindowAsync(BuildingTypeId buildingTypeId);
    [MustUseReturnValue]
    UniTask HandleHide(IWindow window);
}