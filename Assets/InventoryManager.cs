using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Simple manager to respond to inventory related events
/// </summary>
public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    private List<string> inventory;

    /// <summary>
    /// Reponse when we pickup an inventory item
    /// </summary>
    /// <param name="item"></param>
    public void HandleNewInventory(string item)
    {
        inventory.Add(item);
    }
}