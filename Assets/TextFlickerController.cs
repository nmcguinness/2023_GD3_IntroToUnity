using System.Collections;
using TMPro;
using UnityEngine;

public class TextFlickerController : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public string text;
    public float glowPower;

    private Material material;

    private void Start()
    {
        material = textMeshPro.fontMaterial;
        textMeshPro.text = text;

        StartCoroutine(DoFlicker());
    }

    private IEnumerator DoFlicker()
    {
        while (true)
        {
            var randPower = Random.Range(0.2f, 0.7f);
            material.SetFloat("_GlowPower", randPower);
            yield return new WaitForSeconds(0.5f);
        }
    }
}