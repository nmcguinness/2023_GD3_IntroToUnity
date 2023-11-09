using UnityEngine;
using UnityEngine.Events;

namespace GD
{
    public enum PickupType
    {
        SmallClipAmmo,
        MediumClipAmmo,
        LargeClipAmmo,

        //health
    }

    public struct TheData
    {
        public string Name;
        public string Description;
        public string Type;
    }

    public class PickupGameEventListener : BaseGameEventListener<PickupType>
    { }

    public class IntGameEventListener : BaseGameEventListener<int>
    { }

    public class FloatGameEventListener : BaseGameEventListener<float>
    { }

    public class TheDataGameEventListener : BaseGameEventListener<TheData>
    { }

    public abstract class BaseGameEventListener<T> : MonoBehaviour
    {
        [SerializeField]
        private string description;

        [SerializeField]
        [Tooltip("Specify the game event (scriptable object) which will raise the event")]
        private BaseGameEvent<T> Event;  //read event + delegate -> GDEvent

        [SerializeField]
        private UnityEvent<T> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public virtual void OnEventRaised(T data)
        {
            Response?.Invoke(data);
        }
    }
}