using UnityEngine;

namespace UniteScripts
{
    public class DebugDisable : MonoBehaviour
    {
        void Awake()
        {
#if UNITY_EDITOR
            Debug.unityLogger.logEnabled = true;
#else
    Debug.unityLogger.logEnabled = false;
#endif
        }
    }
}

