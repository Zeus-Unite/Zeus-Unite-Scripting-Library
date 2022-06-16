using UnityEngine;


namespace UniteScripts
{
    public class FollowFixedUpdate : MonoBehaviour
    {
        public Transform m_TargetFollow;

        void FixedUpdate()
        {
            transform.position = m_TargetFollow.position;
            transform.rotation = m_TargetFollow.rotation;
        }
    }
}
