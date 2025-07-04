using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Gladiators.Infrastructure
{
    public class EntryPoint : MonoBehaviour
    {
        [Inject]
        private void Construct(IGameStateMachine gameStateMachine)
        {
            gameStateMachine.Enter<BootstrapState>().Forget();
        }
    }
}