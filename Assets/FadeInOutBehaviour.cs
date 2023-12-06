using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class FadeInOutBehaviour : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer renderer;

    [SerializeField]
    private float fadeInDelay = 1;

    [SerializeField]
    [ReadOnly]
    private float fadeInValue = 0;

    private Material fadeTargetMaterial;

    [SerializeField]
    private UnityEvent OnFadeInComplete;

    private void Start()
    {
        if (renderer != null)
            fadeTargetMaterial = renderer.sharedMaterial;

        StartCoroutine(FadeIn());
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    private void Update()
    {
        //if (Input.GetKeyUp(KeyCode.UpArrow))
        //{
        //    fadeTargetMaterial.SetFloat("_Alpha", 0.9f);
        //}
        //else if (Input.GetKeyUp(KeyCode.DownArrow))
        //{
        //    fadeTargetMaterial.SetFloat("_Alpha", 0.1f);
        //}
    }

    //show black sphere
    public IEnumerator FadeIn() //0 -> 1
    {
        while (fadeInValue <= 1)
        {
            fadeInValue += 0.1f;
            fadeTargetMaterial.SetFloat("_Alpha", fadeInValue);
            yield return new WaitForSeconds(fadeInDelay);
        }

        OnFadeInComplete?.Invoke();
    }
}