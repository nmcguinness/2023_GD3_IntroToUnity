using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestImpulseController : MonoBehaviour
{
    [SerializeField]
    [Range(0.1f, 10)]
    private float force;

    private CinemachineCollisionImpulseSource impulseSource;

    private void Start()
    {
        impulseSource = GetComponent<CinemachineCollisionImpulseSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            impulseSource?.GenerateImpulseWithForce(force);
    }
}