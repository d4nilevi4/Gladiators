using Cysharp.Threading.Tasks;

namespace Factory.Infrastructure
{
    public interface IPayloadState<in TPayload> : IExitableState
    {
        UniTask Enter(TPayload payload);
    }
}