using Cinemachine;
using UnityEngine;

namespace UniteScripts
{
    public class CinemachineDollyTrackMover : MonoBehaviour
    {
        [SerializeField] float cameraSpeed = 10;

        CinemachineVirtualCamera m_Camera;
        CinemachineTrackedDolly m_CameraDolly;

        void Start()
        {
            m_Camera = GetComponent<CinemachineVirtualCamera>();
            m_CameraDolly = m_Camera.GetCinemachineComponent<CinemachineTrackedDolly>();
        }

        void Update()
        {
            m_CameraDolly.m_PathPosition += Time.deltaTime * cameraSpeed / 100;
        }
    }
}