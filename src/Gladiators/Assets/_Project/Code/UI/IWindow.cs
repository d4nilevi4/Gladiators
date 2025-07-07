using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace Gladiators.UI;

public interface IWindow
{
    bool IsWindowOpened { get; }
    [MustUseReturnValue] 
    UniTask ShowAsync();
    [MustUseReturnValue] 
    UniTask HideAsync();
}