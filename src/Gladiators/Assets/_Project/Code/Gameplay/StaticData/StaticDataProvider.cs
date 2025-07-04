using Cysharp.Threading.Tasks;
using Factory.Infrastructure;

namespace Factory.Gameplay.StaticData
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