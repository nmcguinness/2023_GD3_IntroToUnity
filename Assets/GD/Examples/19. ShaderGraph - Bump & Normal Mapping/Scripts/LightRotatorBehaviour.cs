using UnityEngine;

namespace GD.Examples
{
    /// <summary>
    /// This script rotates a spotlight around its local X, Y, and Z axes.
    /// Rotation rates for each axis can be adjusted in the Inspector.
    /// The user can also specify the space (local or world) in which the rotations occur.
    /// </summary>
    public class LightRotatorBehaviour : MonoBehaviour
    {
        [Tooltip("Specify the space to be used when rotating")]
        [SerializeField]
        private Space space = Space.World;

        [Tooltip("Rotation rate around X-axis in degrees per second")]
        [SerializeField]
        [Range(0, 360)]
        private float rotationRateX = 30f;

        [Tooltip("Rotation rate around Y-axis in degrees per second")]
        [SerializeField]
        [Range(0, 360)]
        private float rotationRateY = 20f;

        [Tooltip("Rotation rate around Z-axis in degrees per second")]
        [SerializeField]
        [Range(0, 360)]
        private float rotationRateZ = 20f;

        private void Update()
        {
            // Calculate rotation angles based on time and rates
            float rotationX = rotationRateX * Time.deltaTime;
            float rotationY = rotationRateY * Time.deltaTime;
            float rotationZ = rotationRateZ * Time.deltaTime;

            // Rotate the spotlight around the world X and Y axes
            transform.Rotate(Vector3.right, rotationX, space);
            transform.Rotate(Vector3.up, rotationY, space);
            transform.Rotate(Vector3.forward, rotationZ, space);
        }
    }
}