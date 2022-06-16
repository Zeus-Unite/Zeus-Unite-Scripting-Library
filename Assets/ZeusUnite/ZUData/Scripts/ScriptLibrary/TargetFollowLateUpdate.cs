using UnityEngine;

namespace UniteScripts
{
    public class TargetFollowLateUpdate : MonoBehaviour
    {
        public Transform m_FollowTargetLate;

        void FixedUpdate()
        {
            m_FollowTargetLate.transform.position = this.transform.position;
            m_FollowTargetLate.transform.rotation = this.transform.rotation;
        }
    }
}
