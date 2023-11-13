using Sirenix.OdinInspector;
using UnityEngine;

namespace GD
{
    [CreateAssetMenu(fileName = "InteractableObjectData", menuName = "DkIT/Scriptable Objects/Game/Objects/Interactable")]
    public class InteractableObjectData : BaseObjectData
    {
        [Tooltip("Icon used by onscreen UI and any notification panel popups")]
        [PreviewField(50, ObjectFieldAlignment.Right)]
        public Sprite icon;

        [TabGroup("tab1", "Audio", SdfIconType.Soundwave)]
        [Tooltip("Audio clipped played when interactable is picked up")]
        public AudioClip PickupClip;

        [TabGroup("tab1", "Audio")]
        [Tooltip("Audio clipped played when interactable is used")]
        public AudioClip UseClip;

        [TabGroup("tab1", "Audio")]
        [Tooltip("Audio clipped played when interactable is dropped")]
        public AudioClip DropClip;

        [TabGroup("tab1", "Lifecycle", SdfIconType.SuitHeartFill)]
        [Tooltip("Amount of time(secs) before a visible unused item is removed (-1 = no removal)")]
        [Unit(Units.Second)]
        public float LivesForSecs;

        [TabGroup("tab1", "Lifecycle")]
        [Tooltip("Amount of time(secs) until respawn following consumption (-1 = respawn never, 0 = respawn immediate)")]
        [Unit(Units.Second)]
        public float RespawnEverySecs;
    }
}