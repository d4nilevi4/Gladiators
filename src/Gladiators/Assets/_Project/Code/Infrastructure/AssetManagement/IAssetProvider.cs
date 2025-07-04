using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Gladiators.Infrastructure
{
    public interface IAssetProvider
    {
        UniTask<T> LoadAsset<T>(string path) where T : Object;
        UniTask<T[]> LoadAll<T>(string path) where T : Object;
    }
}