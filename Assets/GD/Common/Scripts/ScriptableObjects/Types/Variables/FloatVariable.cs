using UnityEngine;

namespace GD
{
    [CreateAssetMenu(fileName = "FloatVariable",
        menuName = "DkIT/Scriptable Objects/Variables/Float")]
    public class FloatVariable : ScriptableDataType<float>
    {
        public void Add(FloatVariable a)
        {
            Value += a.Value;
        }

        public void Set(FloatVariable a)
        {
            Set(a.Value);
        }

        public bool Equals(FloatVariable other)
        {
            return Value.Equals(other.Value);
        }
    }
}