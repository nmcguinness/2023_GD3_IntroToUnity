using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class AdvancedTweenBehaviour : MonoBehaviour
{
    [Header("Scale Factor")]
    public float scaleFactor;

    [Header("Scaling Up - Timing & Ease")]
    public float scaleUpDuration;

    public Ease easeInCurve;// = AnimationCurve.Linear;

    [Header("Delay Properties")]
    public float delay = 1;

    [Header("Scaling Down - Timing & Ease")]
    public float scaleDownDuration;

    public Ease easeOutCurve;

    [Header("Tween Events")]
    public UnityEvent OnCycle;

    private Vector3 originalScale;
    private Vector3 scaleTo;

    private void Start()
    {
        originalScale = gameObject.transform.localScale;
        scaleTo = originalScale * scaleFactor;

        ScaleUp();
    }

    public void ScaleUp()
    {
        gameObject.transform.DOScale(scaleTo,
            scaleUpDuration)
            .SetLoops(1, LoopType.Restart)
            .SetEase(easeInCurve)
            .OnComplete(() => { ScaleDown(); });
    }

    private void ScaleDown()
    {
        gameObject.transform.DOScale(originalScale, scaleDownDuration)
        .SetLoops(1, LoopType.Restart)
        .SetEase(easeOutCurve)
        .SetDelay(delay)
        .OnComplete(() =>
        {
            OnCycle.Invoke();
            ScaleUp();
        });
    }
}