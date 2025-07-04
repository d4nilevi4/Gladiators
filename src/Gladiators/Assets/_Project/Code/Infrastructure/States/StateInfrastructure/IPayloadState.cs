using Cysharp.Threading.Tasks;

namespace Gladiators.Infrastructure
{
    public interface IPayloadState<in TPayload> : IExitableState
    {
        UniTask Enter(TPayload payload);
    }
}