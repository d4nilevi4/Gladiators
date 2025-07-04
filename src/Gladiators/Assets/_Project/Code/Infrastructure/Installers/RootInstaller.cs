using Zenject;

namespace Factory.Infrastructure
{
    public class RootInstaller : MonoInstaller
    {
        private IMonoInstaller[] _installers;

        public override void InstallBindings()
        {
            _installers = GetComponents<IMonoInstaller>();

            foreach (IMonoInstaller installer in _installers)
                installer.InstallBindings(Container);
        }
    }
}