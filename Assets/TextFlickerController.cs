using Sirenix.OdinInspector;
using System.Collections;
using TMPro;
using UnityEngine;

public class TextFlickerController : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public string text;

    [Range(0, 1)]
    public float minPower = 0;

    [Range(0, 1)]
    public float maxPower = 1;

    [Range(0.1f, 5)]
    [Unit(Units.Second)]
    public float waitSeconds = 0.2f;

    private Material material;

    private void Start()
    {
        material = textMeshPro.fontMaterial;
        textMeshPro.text = text;

        var myRoutine = StartCoroutine(DoFlicker());

        //    StopCoroutine(myRoutine);
        //    StopAllCoroutines();
    }

    private IEnumerator DoFlicker()
    {
        while (true)
        {
            var randPower = Random.Range(minPower, maxPower);
            material.SetFloat("_GlowPower", randPower);
            yield return new WaitForSeconds(waitSeconds);
        }
    }

    private IEnumerator DoSomethingOverTime()
    {
        yield return new WaitForSeconds(2);

        ///   System.Threading.Thread.Sleep(2);

        Debug.Log("do something...");

        yield return new WaitForSeconds(5);

        Debug.Log("do something else...");

        yield return null;
    }
}