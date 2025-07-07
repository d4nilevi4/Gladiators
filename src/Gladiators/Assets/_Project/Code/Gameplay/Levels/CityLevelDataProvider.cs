using Gladiators.Gameplay.Environment;

namespace Gladiators.Gameplay.Levels
{
    public class CityLevelDataProvider : ICityLevelDataProvider
    {
        public ICityEnvironmentRoot EnvironmentRoot { get; private set; }
        
        public void SetEnvironmentRoot(ICityEnvironmentRoot environmentRoot)
        {
            EnvironmentRoot = environmentRoot;
        }
    }
}