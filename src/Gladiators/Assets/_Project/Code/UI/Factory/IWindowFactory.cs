namespace Gladiators.UI.City;

public interface IWindowFactory
{
    T CreateWindow<T>() where T : IWindow;
}