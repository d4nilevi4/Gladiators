using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Factory.Infrastructure
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