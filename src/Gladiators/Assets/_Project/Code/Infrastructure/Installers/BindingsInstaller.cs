using UnityEngine;
using Zenject;

namespace Factory.Infrastructure
{
    public abstract class BindingsInstaller : MonoBehaviour, IMonoInstaller
    {
        public abstract void InstallBindings(DiContainer container);
    }
}