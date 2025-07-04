using System.Collections;
using UnityEngine;

namespace Factory.Infrastructure
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator load);
    }
}