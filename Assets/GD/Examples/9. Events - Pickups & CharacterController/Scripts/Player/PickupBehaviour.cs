using GD;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour
{
    [SerializeField]
    private StringGameEvent OnPickup;

    [SerializeField]
    private string targetTag = "Consumable";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(targetTag))
        {
            OnPickup?.Raise("small ammo clip");

            //  ConsumableObject consumableObject;
            //  other.gameObject.TryGetComponent<ConsumableObject>(out consumableObject);
            // ConsumableObject consumableObject =
            //other.gameObject.GetComponent<ConsumableObject>();

            // //yeah, it has that thing on it
            // if (consumableObject != null)
            // {
            //     OnPickup?.Raise(consumableObject.ConsumableData.UniqueID);

            //     //AudioSource.PlayClipAtPoint(
            //     //    consumableObject.ConsumableData.PickupClip,
            //     //    other.gameObject.transform.position);
            // }
        }
    }
}

/*
 public class PickupBehaviour : MonoBehaviour
{
    [SerializeField]
    private StringGameEvent OnPickup;

    [SerializeField]
    private string targetTag = "Consumable";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(targetTag))
        {
            OnPickup.Raise("ammo");
            Destroy(other.gameObject);
            //PlaySound()
        }
    }
}

 */