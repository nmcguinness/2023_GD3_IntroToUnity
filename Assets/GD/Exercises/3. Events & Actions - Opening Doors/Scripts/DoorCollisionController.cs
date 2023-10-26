using UnityEngine;
using UnityEngine.Events;

public class DoorCollisionController : MonoBehaviour
{
    [SerializeField]
    private UnityAction onTriggerEnter;

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnter?.Invoke();
    }

    //DELEGATE

    //EVENT
}