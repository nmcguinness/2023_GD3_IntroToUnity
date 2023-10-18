using UnityEngine;

[CreateAssetMenu(fileName = "RotationParameters",
    menuName = "DkIT/Scriptable Objects/Other/Parameters/Rotation")]
public class RotationParameters : ScriptableObject
{
    public float RotationAngle;
    public Vector3 RotationAxis;
}