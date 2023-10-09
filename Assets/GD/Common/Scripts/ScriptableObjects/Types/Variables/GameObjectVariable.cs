using UnityEngine;

namespace GD.ScriptableTypes
{
    [CreateAssetMenu(fileName = "GameObjectVariable", menuName = "DkIT/Scriptable Objects/Variables/Game Object")]
    public class GameObjectVariable : ScriptableDataType<GameObject>
    {
        public void Set(GameObjectVariable a)
        {
            Set(a.Value);
        }

        public bool Equals(GameObjectVariable other)
        {
            return Value.Equals(other.Value);
        }
    }
}