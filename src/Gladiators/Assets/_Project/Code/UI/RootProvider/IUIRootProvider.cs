namespace Gladiators.UI;

public interface IUIRootProvider
{
    Transform UIRoot { get; }
    void SetUIRoot(Transform root);
}