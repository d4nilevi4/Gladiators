using Zenject;

namespace Gladiators.Infrastructure
{
    public interface IMonoInstaller
    {
        void InstallBindings(DiContainer container);
    }
}