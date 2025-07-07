namespace Gladiators.Gameplay.Environment;

public interface ICityEnvironmentRoot
{
    Transform EnvironmentRoot { get; }
    Transform GroundRoot { get; }
    Transform BuildingsRoot { get; }
}