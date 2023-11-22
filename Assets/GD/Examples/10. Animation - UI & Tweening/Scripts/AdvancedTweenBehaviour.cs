using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class AdvancedTweenBehaviour : MonoBehaviour
{
    private Vector3 originalScale;
    public float scaleFactor;
    public float scaleUpDuration;
    public float scaleDownDuration;

    public AnimationCurve easeInCurve;// = AnimationCurve.Linear;
    public Ease easeOutCurve;

    public UnityEvent OnCycle;

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
        .OnComplete(() =>
        {
            OnCycle.Invoke();
            ScaleUp();
        });
    }
}