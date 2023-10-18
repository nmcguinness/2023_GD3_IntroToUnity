using UnityEngine;

public class TestPrefabScriptable : MonoBehaviour
{
    [SerializeField]
    private PrefabScriptableTest so;

    // Start is called before the first frame update
    private void Start()
    {
        so.ShowPrefab(gameObject.transform.position);
    }

    private void OnDestroy()
    {
        so.DestroyPrefab();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}