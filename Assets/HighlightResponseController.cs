using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightResponseController : MonoBehaviour
{
    public void SetPosition(Vector3 position)
    {
        gameObject.transform.position = position;
    }

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }
}