using UnityEngine;

namespace GD
{
    public class InventoryManager : Singleton<InventoryManager>
    {
        [SerializeField]
        private int x;

        [SerializeField]
        public FloatReference someValue;

        public int X { get => x; set => x = value; }

        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}