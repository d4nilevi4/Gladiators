namespace Gladiators.UI.City;

public class WindowFactory : IWindowFactory
{
    private readonly IInstantiator _instantiator;

    public WindowFactory(
        IInstantiator instantiator
    )
    {
        _instantiator = instantiator;
    }
    
    public T CreateWindow<T>() where T : IWindow => 
        _instantiator.Instantiate<T>();
}