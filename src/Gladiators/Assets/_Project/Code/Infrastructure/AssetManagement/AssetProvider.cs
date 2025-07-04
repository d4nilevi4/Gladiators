using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Factory.Infrastructure
{
    public class AssetProvider : IAssetProvider
    {
        public UniTask<T> LoadAsset<T>(string path) where T : Object =>
            new(Resources.Load<T>(path));

        public UniTask<T[]> LoadAll<T>(string path) where T : Object => 
            new (Resources.LoadAll<T>(path));
    }
}