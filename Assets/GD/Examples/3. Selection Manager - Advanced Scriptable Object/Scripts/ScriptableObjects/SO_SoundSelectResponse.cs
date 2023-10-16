using GD.Selection;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_SoundSelectionResponse",
    menuName = "DkIT/Scriptable Objects/Responses/Sound")]
[Serializable]
public class SO_SoundSelectionResponse : ScriptableObject, ISelectionResponse
{
    [SerializeField]
    private AudioClip selectedAudioClip;

    private Transform currentTransform = null;

    public void OnDeselect(Transform transform)
    {
    }

    public void OnSelect(Transform transform)
    {
        if (currentTransform != null && currentTransform != transform)
            AudioSource.PlayClipAtPoint(selectedAudioClip, transform.position);
        currentTransform = transform;
    }
}