using UnityEngine;

namespace UniteScripts
{
    public class TargetFollowFixedUpdate : MonoBehaviour
    {
        public Transform m_TargetFollow;

        void FixedUpdate()
        {
            m_TargetFollow.transform.position = this.transform.position;
            m_TargetFollow.transform.rotation = this.transform.rotation;
        }
    }
}