namespace Gladiators.UI;

public class UIRootProvider : IUIRootProvider
{
    public Transform UIRoot { get; private set; }
    
    public void SetUIRoot(Transform root)
    {
        UIRoot = root;
    }
}