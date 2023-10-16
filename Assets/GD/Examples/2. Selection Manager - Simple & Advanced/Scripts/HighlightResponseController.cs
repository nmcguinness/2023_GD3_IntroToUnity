using UnityEngine;

public class HighlightResponseController : MonoBehaviour
{
    [SerializeField]
    [Range(-1f, 1f)]
    private float rotationAngle = 0.1f;

    [SerializeField]
    private Vector3 positionOffset;

    [SerializeField]
    [Range(0.01f, 0.2f)]
    private float scaleFactor = 0.1f;

    [SerializeField]
    [Range(0, 20)]
    private float angularSpeed = 0.8f;

    private Vector3 originalScale;

    private void Awake()
    {
        originalScale = transform.localScale;
    }

    public void SetPosition(Vector3 position)
    {
        //store original to always scale from original
        gameObject.transform.position = position + positionOffset;
    }

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    private void Update() //60Hz -> 16ms
    {
        //rotate
        gameObject.transform.Rotate(gameObject.transform.up, rotationAngle);
        //scale
        var scale = (scaleFactor * Mathf.Sin(angularSpeed * Time.time)) + 1;
        gameObject.transform.localScale = scale * originalScale;
    }
}