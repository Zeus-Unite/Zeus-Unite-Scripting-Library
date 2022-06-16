using UnityEngine;


namespace UniteScripts
{
    /// <summary>
    /// We use Time.deltaTime so the Rotator can be fine adjusted
    /// Ranges from 5 - 50 work well
    /// </summary>
    public class TransformRotator : MonoBehaviour
    {
        [SerializeField] float xAngle = 0;
        [SerializeField] float yAngle = 0;
        [SerializeField] float zAngle = 0;

        void Update()
        {
            transform.Rotate(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime);
        }
    }
}
