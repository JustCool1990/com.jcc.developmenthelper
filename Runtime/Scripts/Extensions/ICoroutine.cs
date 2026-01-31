using UnityEngine;
using System.Collections;
using UnityEngine.Scripting;

namespace JCC.DevHelper
{
    [Preserve]
    public interface ICoroutine
    {
        public Coroutine StartCoroutine(IEnumerator coroutine);
        public void StopCoroutine(Coroutine coroutine);
        public void StopCoroutine(IEnumerator waitCoroutine);
    }
}
