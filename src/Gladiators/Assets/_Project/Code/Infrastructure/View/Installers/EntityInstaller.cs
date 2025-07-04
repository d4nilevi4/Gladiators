using Zenject;

namespace Factory.Infrastructure
{
    public class EntityInstaller : BindingsInstaller
    {
        public EntityBehaviorProvider EntityBehaviorProvider;
        
        public override void InstallBindings(DiContainer container)
        {
            container.Bind<IEntityBehaviorProvider>().FromInstance(EntityBehaviorProvider).AsSingle();
        }
    }
}