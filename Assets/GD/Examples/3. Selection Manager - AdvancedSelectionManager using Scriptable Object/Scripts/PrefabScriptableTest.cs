using UnityEngine;

[CreateAssetMenu(fileName = "PrefabScriptableTest", menuName = "DkIT/Scriptable Objects/PrefabScriptableTest", order = 1)]
public class PrefabScriptableTest : ScriptableObject
{
    [SerializeField]
    [Tooltip("Set prefab object used for target highlighting")]
    private GameObject targetSelectionPrefab;

    private GameObject current;

    public void ShowPrefab(Vector3 position)
    {
        if (targetSelectionPrefab != null && current == null)
        {
            current = Instantiate(targetSelectionPrefab, position, Quaternion.identity);
        }
    }

    public void DestroyPrefab()
    {
        if (current != null)
        {
            Destroy(current);
            current = null;
        }
    }
}