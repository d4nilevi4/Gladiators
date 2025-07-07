using Cysharp.Threading.Tasks;
using Gladiators.UI;

namespace Gladiators.Gameplay;

public static class CommonExtensions
{
    public static UniTask ShowIfNotOpened(this IWindow window)
    {
        if(window.IsWindowOpened)
            return UniTask.CompletedTask;

        return window.ShowAsync();
    }
        
    public static UniTask HideIfOpened(this IWindow window)
    {
        if(!window.IsWindowOpened)
            return UniTask.CompletedTask;

        return window.HideAsync();
    }

    public static void DestroyUnityObjectIfExist(this MonoBehaviour obj)
    {
        if (obj)
            Object.Destroy(obj.gameObject);
    }
}