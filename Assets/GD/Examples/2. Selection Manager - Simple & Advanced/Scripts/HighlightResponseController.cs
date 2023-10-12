using UnityEngine;

public class HighlightResponseController : MonoBehaviour
{
    [SerializeField]
    [Range(-1f, 1f)]
    private float rotationAngle;

    [SerializeField]
    private Vector3 positionOffset;

    [SerializeField]
    [Range(0.01f, 0.12f)]
    private float scaleFactor;

    [SerializeField]
    [Range(-10, 10)]
    private float angularSpeed;

    //[SerializeField]
    //[Range(0, 4)]
    //private float userTimeScale;

    //private void Awake()
    //{
    //      Time.timeScale = userTimeScale;
    //}

    public void SetPosition(Vector3 position)
    {
        gameObject.transform.position = position + positionOffset;
    }

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    private void Update() //60Hz -> 16ms
    {
        var scale = scaleFactor * Mathf.Sin(angularSpeed * Time.time) + 1;
        gameObject.transform.localScale = scale * Vector3.one;
    }
}