using UnityEngine;

/// <summary>
/// Performs axis, angle rotation of a game object via centrally controlled ScriptableObject (SO) variables
/// </summary>
public class SORotationBehaviour : MonoBehaviour
{
    [SerializeField]
    private RotationParameters rotationParameters;

    [SerializeField]
    private Space rotationSpace;

    // Update is called every frame, if the MonoBehaviour is enabled
    private void Update()
    {
        gameObject.transform.Rotate(rotationParameters.RotationAxis,
            rotationParameters.RotationAngle,
            rotationSpace);
    }
}