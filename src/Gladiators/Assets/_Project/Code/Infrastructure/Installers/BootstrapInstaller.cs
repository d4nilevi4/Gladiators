using System;
using Cysharp.Threading.Tasks;
using Gladiators.Common;
using Gladiators.Gameplay;
using Gladiators.Gameplay.Cameras;
using Gladiators.Gameplay.Input;
using Gladiators.Gameplay.Levels;
using Gladiators.Gameplay.StaticData;
using Gladiators.UI;
using Gladiators.UI.City;
using UnityEngine;
using Zenject;

namespace Gladiators.Infrastructure
{
    public class BootstrapInstaller : MonoInstaller, IInitializable, ICoroutineRunner, IDrawGizmoReceiver
    {
        public event Action EventDrawGizmo;

        public override void InstallBindings()
        {
            BindInputService();
            BindInfrastructureServices();
            BindAssetManagementServices();
            BindCommonServices();
            BindSystemFactory();
            BindContexts();
            BindStateMachine();
            BindStateFactory();
            BindGameStates();
            BindGameplayServices();
            BindGameplayFactories();
            BindUIServices();
            BindUIFactories();
            BindEntityIndices();

            Container.Bind<IInitializable>().FromInstance(this);
        }

        private void BindStateMachine()
        {
            Container.BindInterfacesAndSelfTo<GameStateMachine>().AsSingle();
        }

        private void BindStateFactory()
        {
            Container.BindInterfacesAndSelfTo<StateFactory>().AsSingle();
        }

        private void BindGameStates()
        {
            Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
            Container.BindInterfacesAndSelfTo<LoadProgressState>().AsSingle();
            
            Container.BindInterfacesAndSelfTo<LoadingMenuState>().AsSingle();
            Container.BindInterfacesAndSelfTo<MenuLoopState>().AsSingle();
            
            Container.BindInterfacesAndSelfTo<LoadCityState>().AsSingle();
            Container.BindInterfacesAndSelfTo<EnterCityState>().AsSingle();
            Container.BindInterfacesAndSelfTo<CityLoopState>().AsSingle();
            
            Container.BindInterfacesAndSelfTo<LoadArenaState>().AsSingle();
            Container.BindInterfacesAndSelfTo<EnterArenaState>().AsSingle();
            Container.BindInterfacesAndSelfTo<ArenaLoopState>().AsSingle();
        }

        private void BindContexts()
        {
            Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();

            Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
            Container.Bind<InputContext>().FromInstance(Contexts.sharedInstance.input).AsSingle();
        }

        private void BindSystemFactory()
        {
            Container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();
        }

        private void BindInfrastructureServices()
        {
            Container.Bind<ICoroutineRunner>().FromInstance(this).AsSingle();
            Container.Bind<IIdentifierService>().To<IdentifierService>().AsSingle();
        }

        private void BindAssetManagementServices()
        {
            Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
        }

        private void BindCommonServices()
        {
            Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
            Container.Bind<ICollisionRegistry>().To<CollisionRegistry>().AsSingle();
            Container.Bind<IDrawGizmoReceiver>().FromInstance(this).AsSingle();
            Container.Bind<ILogger>().FromInstance(Debug.unityLogger).AsSingle();
        }

        private void BindInputService()
        {
            Container.BindInterfacesTo<MainInput>().AsSingle();
            Container.Bind<ILocomotionInput>().To<LocomotionInput>().AsSingle();
            Container.Bind<IInteractionInput>().To<InteractionInput>().AsSingle();
        }

        private void BindGameplayServices()
        {
            Container.Bind<ITimeService>().To<UnityTimeService>().AsSingle();
            Container.Bind<ICameraProvider>().To<CameraProvider>().AsSingle();
            Container.Bind<IStaticDataProvider>().To<StaticDataProvider>().AsSingle();
            
            Container.Bind<ICityLevelDataProvider>().To<CityLevelDataProvider>().AsSingle();
            
            Container.Bind<IArenaLevelDataProvider>().To<ArenaLevelDataProvider>().AsSingle();
        }

        private void BindGameplayFactories()
        {
            Container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
        }

        private void BindUIServices()
        {
            Container.Bind<IBuildingWindowsController>().To<BuildingWindowsController>().AsSingle();
            Container.Bind<IUIRootProvider>().To<UIRootProvider>().AsSingle();
        }

        private void BindUIFactories()
        {
            Container.Bind<IWindowFactory>().To<WindowFactory>().AsSingle();
            Container.Bind<ICityWindowViewFactory>().To<CityWindowViewFactory>().AsSingle();
        }

        private void BindEntityIndices()
        {
            // Container.BindInterfacesAndSelfTo<GameEntityIndices>().AsSingle();
        }

        private void OnDrawGizmos()
        {
            EventDrawGizmo?.Invoke();
        }

        public void Initialize()
        {
            UniTaskScheduler.UnobservedTaskException += ex =>
            {
                Container
                    .Resolve<ILogger>()
                    .LogError(
                        tag: "¯\\_(ツ)_/¯", 
                        message: $"Unobserved exception: {ex.Message}\n{ex.StackTrace}");
            };
        }
    }
}