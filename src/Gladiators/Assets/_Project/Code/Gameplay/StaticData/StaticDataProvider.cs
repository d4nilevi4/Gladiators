using Cysharp.Threading.Tasks;
using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.StaticData
{
    public class StaticDataProvider : IStaticDataProvider
    {
        private readonly IAssetProvider _assetProvider;
        
        public StaticDataProvider(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public UniTask LoadAll()
        {
            return UniTask.CompletedTask;
        }
    }
}