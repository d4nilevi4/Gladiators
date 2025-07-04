using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Gladiators.Infrastructure
{
    public class SceneInitializationInstaller : MonoInstaller
    {
        public List<MonoBehaviour> Initializers;

        public override void InstallBindings()
        {
            foreach (MonoBehaviour initializer in Initializers)
            {
                Container.BindInterfacesTo(initializer.GetType()).FromInstance(initializer).AsSingle();
            }
        }
    }
}