using System.Collections;
using UnityEngine;

namespace Gladiators.Infrastructure
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator load);
    }
}