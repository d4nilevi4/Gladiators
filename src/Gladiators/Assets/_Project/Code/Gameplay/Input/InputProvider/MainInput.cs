namespace Gladiators.Gameplay.Input;

public class MainInput : IInput, IDisposable
{
    public PlayerInputActions Input { get; } = new ();

    public void Dispose()
    {
        Input?.Dispose();
    }
}