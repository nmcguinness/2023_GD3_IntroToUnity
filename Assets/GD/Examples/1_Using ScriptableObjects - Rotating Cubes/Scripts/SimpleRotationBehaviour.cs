using UnityEngine;

/// <summary>
/// Performs simple axis, angle rotation of a game object via Inspector visible variables
/// </summary>
public class SimpleRotationBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotatationAxis;

    [SerializeField]
    private float rotationAngleInDegs;

    [SerializeField]
    private Space rotationSpace;

    // Update is called every frame, if the MonoBehaviour is enabled
    private void Update()
    {
        gameObject.transform.Rotate(rotatationAxis, rotationAngleInDegs,
            rotationSpace);
    }
}