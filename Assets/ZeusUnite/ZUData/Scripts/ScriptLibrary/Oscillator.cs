using UnityEngine;
namespace UniteScripts
{
    /// <summary>
    /// The Oscillator can be used to Transform a GameObject  as Sinus between Position A and Position B
    /// It Smoothly Translates the Position of an Object
    /// Slows Down at the End and Beginning and Speed Up towards Center
    /// Can be used in 2D and 3D Games
    /// </summary>
    public class Oscillator : MonoBehaviour
    {
        [SerializeField] float sinModifier = 3f;
        float CalculateSin => Mathf.PI * sinModifier;

        [SerializeField] Vector3 moveToVector;
        [SerializeField] float timeForMovement = 2f;

        Vector3 startingPosition;
        float movementFactor;

        void Start()
        {
            startingPosition = transform.position;
        }

        void Update()
        {
            if (timeForMovement <= Mathf.Epsilon)
                return;

            float timeCycle = Time.time / timeForMovement;

            float rawSinWave = Mathf.Sin(timeCycle * CalculateSin);

            movementFactor = (rawSinWave + 1f) / 2f;

            Vector3 offset = moveToVector * movementFactor;
            transform.position = startingPosition + offset;
        }
    }
}