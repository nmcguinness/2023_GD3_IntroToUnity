using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;
using Sirenix.OdinInspector;
using UnityEngine;

public class TweenedBehaviour : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10)]
    [Unit(Units.Second)]
    private float tweenDuration;

    [SerializeField]
    private Ease easeFunction = Ease.InOutSine;

    [SerializeField]
    private Vector3 moveVector = Vector3.up;

    [SerializeField]
    [Range(0.01f, 10)]
    [Unit(Units.Second)]
    private float rotationDuration;

    private Material material;

    private void Start()
    {
        material = gameObject.GetComponent<Renderer>().material;

        material.DOColor(Color.red, tweenDuration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);

        Path path = new Path(PathType.CubicBezier,
            new[] { new Vector3(0, 2, 0), new Vector3(0, 4, 0), new Vector3(0, 5, 0) }, 10);

        gameObject.transform.DOPath(path, 10);

        var targetLocalPosition = gameObject.transform.localPosition + moveVector;
        gameObject.transform.DOLocalMove(targetLocalPosition, tweenDuration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(easeFunction);

        gameObject.transform.DOLocalRotate(new Vector3(0, 180, 0), rotationDuration)
            .SetLoops(-1, LoopType.Incremental)
            .SetEase(Ease.Linear);
    }
}