using UnityEngine;

namespace GD.Selection
{
    public class SelectionManager : MonoBehaviour
    {
        private IProvideRay rayProvider;
        private ISelectObject selector;
        private ISelectResponse selectionResponse;
    }
}