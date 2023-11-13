using UnityEngine;

namespace GD
{
    public class ScriptableGameObject : ScriptableObject
    {
        [Header("General Info")]
        [ContextMenuItem("Reset Description", "ResetDescription")]
        public string Description;

        //[ContextMenuItem("Set Now", "SetNow")]
        //public string LastUpdated = DateTime.Now.ToString("dd/MM/yy");

        //public void SetNow()
        //{
        //    LastUpdated = DateTime.Now.ToString("dd/MM/yy");
        //}

        public void ResetDescription()
        {
            Description = "";
        }
    }
}