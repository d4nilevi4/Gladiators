using Zenject;

namespace Factory.Infrastructure
{
    public interface IMonoInstaller
    {
        void InstallBindings(DiContainer container);
    }
}