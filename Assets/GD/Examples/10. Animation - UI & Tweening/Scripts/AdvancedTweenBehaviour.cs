using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedTweenBehaviour : MonoBehaviour
{
    private Vector3 originalScale;
    public float scaleFactor;
    public float scaleUpDuration;
    public float scaleDownDuration;
    private Ease easeInCurve;
    private Ease easeOutCurve;

    private void Start()
    {
        ScaleUp();
        originalScale = gameObject.transform.localScale;
    }

    public void ScaleUp()
    {
        gameObject.transform.DOBlendableScaleBy(
            originalScale * scaleFactor,
            scaleUpDuration)
            .SetLoops(1, LoopType.Restart)
            .SetEase(easeInCurve)
            .OnComplete(() => { ScaleDown(); });
    }

    private void ScaleDown()
    {
        gameObject.transform.DOBlendableScaleBy(originalScale * -scaleFactor,
            scaleDownDuration)
        .SetLoops(1, LoopType.Restart)
        .SetEase(easeOutCurve)
        .SetDelay(1)
        .OnComplete(ScaleUp);
    }
}