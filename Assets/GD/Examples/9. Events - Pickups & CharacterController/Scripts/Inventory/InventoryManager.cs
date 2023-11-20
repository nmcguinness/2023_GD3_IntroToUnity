using GD;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// Simple manager to respond to inventory related events
/// </summary>
public class InventoryManager : MonoBehaviour
{
    //[SerializeField]
    //private GameElementDataMapping mapping;

    //[SerializeField]
    //private List<string> inventory;

    [SerializeField]
    private Dictionary<string, int> inventory;

    /// <summary>
    /// Reponse when we pickup an inventory item
    /// </summary>
    /// <param name="item"></param>
    public void HandleNewInventory(string name)
    {
        if (name.Equals("small ammo clip"))
        {
            int amount = inventory[name];
            amount++;
            inventory.Add(name, amount);
        }
        //ConsumableObjectData consumableObjectData;
        //// mapping.Consumables.TryGetValue(guID, out consumableObjectData);

        //consumableObjectData = mapping.Consumables[guID];

        //if (consumableObjectData != null)
        //{
        //    //AudioSource.PlayClipAtPoint(
        //    //     consumableObjectData.PickupClip,
        //    //     Camera.main.transform.position);

        //    Debug.Log(consumableObjectData.buffs[0].ToString());
        //}
    }
}