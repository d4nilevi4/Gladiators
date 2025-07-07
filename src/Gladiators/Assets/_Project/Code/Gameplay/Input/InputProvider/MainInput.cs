namespace Gladiators.Gameplay.Input;

public class MainInput : IInput, IInitializable, IDisposable
{
    public PlayerInputActions Input { get; private set; }

    public void Initialize()
    {
        Input = new PlayerInputActions();
    }

    public void Dispose()
    {
        Input?.Dispose();
    }
}