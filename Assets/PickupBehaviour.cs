using GD;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour
{
    [SerializeField]
    private StringGameEvent OnPickup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.CompareTo("Consumable") == 0)
        {
            OnPickup.Raise("ammo");
            Destroy(other.gameObject);
            //PlaySound()
        }
    }
}