using UnityEngine;

[CreateAssetMenu(fileName = "My File Name",
    menuName = "GD/Scriptable Objects/Parameters/Rotation")]
public class RotationParameters : ScriptableObject
{
    public float RotationAngle;
    public Vector3 RotationAxis;
}