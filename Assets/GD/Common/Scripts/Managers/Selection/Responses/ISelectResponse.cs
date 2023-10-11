using UnityEngine;

namespace GD.Selection
{
    public interface ISelectResponse
    {
        void OnSelect(Transform transform);

        void OnDeselect(Transform transform);
    }
}