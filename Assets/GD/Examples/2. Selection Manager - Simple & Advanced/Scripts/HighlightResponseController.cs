using UnityEngine;

public class HighlightResponseController : MonoBehaviour
{
    [SerializeField]
    [Range(-1f, 1f)]
    private float rotationAngle;

    [SerializeField]
    private Vector3 positionOffset;

    public void SetPosition(Vector3 position)
    {
        gameObject.transform.position = position + positionOffset;
    }

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    private void Update()
    {
        //gameObject.transform.localScale = scale * Vector3.one;
    }
}