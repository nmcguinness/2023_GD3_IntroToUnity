using UnityEngine;

/// <summary>
/// Demo to show a simple UI manager listening for int game events (e.g. send a single integer like health)
/// </summary>
public class SimpleUIManager : MonoBehaviour
{
    public void HandleHealthChange(int newHealth)
    {
        Debug.Log($"SimpleUIManager::New health is {newHealth}");
    }

    public void HandleNewInventory(string item)
    {
        Debug.Log($"SimpleUIManager::New item is {item}");
    }
}