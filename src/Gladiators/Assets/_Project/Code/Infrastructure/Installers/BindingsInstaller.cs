using UnityEngine;
using Zenject;

namespace Gladiators.Infrastructure
{
    public abstract class BindingsInstaller : MonoBehaviour, IMonoInstaller
    {
        public abstract void InstallBindings(DiContainer container);
    }
}