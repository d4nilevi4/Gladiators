using Gladiators.Gameplay.Environment;

namespace Gladiators.Gameplay.Levels
{
    public interface ICityLevelDataProvider
    {
        ICityEnvironmentRoot EnvironmentRoot { get; }
        
        void SetEnvironmentRoot(ICityEnvironmentRoot environmentRoot);
    }
}