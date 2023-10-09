using UnityEngine;

namespace GD
{
    public class ScriptableGameObject : ScriptableObject
    {
        [Header("Useful Info")]
        [ContextMenuItem("Reset Description", "ResetDescription")]
        public string Description;

        public void ResetDescription()
        {
            Description = "";
        }
    }
}