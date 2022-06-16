using UnityEngine;

namespace UniteScripts
{
    public class FollowLateUpdate : MonoBehaviour
    {
        public Transform m_FollowTargetLate;

        void LateUpdate()
        {
            transform.position = m_FollowTargetLate.position;
            transform.rotation = m_FollowTargetLate.rotation;
        }
    }
}