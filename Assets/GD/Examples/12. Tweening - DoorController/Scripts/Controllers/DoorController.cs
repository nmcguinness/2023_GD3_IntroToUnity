using GD;
using System;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [Header("Target & Markers")]
    [SerializeField]
    [Tooltip("Gameobject to be opened/closed")]
    private GameObject door;

    [SerializeField]
    [Tooltip("A gameobject empty marker set on the edge of the door that opens/closes")]
    private Transform edgeMarker;

    [SerializeField]
    [Tooltip("A gameobject empty marker set on the closed position of the door")]
    private Transform closeMarker;

    [Space]
    [Header("Movement Direction")]
    [Tooltip("Direction in which to open/close the door")]
    [SerializeField]
    private Vector3 openCloseDirection;

    [Space]
    [Header("Closing Duration & Ease Function")]
    [SerializeField]
    [Range(0, 20)]
    private float closeDurationSecs = 0.25f;

    [Header("Opening Duration & Ease Function")]
    [SerializeField]
    [Range(0, 20)]
    private float openDurationSecs = 0.25f;

    [SerializeField]
    [ReadOnly]
    private ActivationStateType doorState;

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        //To Do...
    }
}