using UnityEngine;

public class TankTurretController : MonoBehaviour
{
    [SerializeField]
    private Transform turrentTransform;

    [SerializeField]
    private Transform gunTransform;

    [SerializeField, Range(-0.5f, 0.5f)]
    private float turretRotationRate;

    [SerializeField, Range(-0.25f, 0.25f)]
    private float gunRotationRate;

    // Update is called once per frame
    private void Update()
    {
        turrentTransform.Rotate(turrentTransform.up, turretRotationRate);

        gunTransform.Rotate(gunTransform.right, gunRotationRate);
    }
}