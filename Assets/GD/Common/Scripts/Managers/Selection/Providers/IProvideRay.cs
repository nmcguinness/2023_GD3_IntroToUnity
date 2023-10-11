using UnityEngine;

namespace GD.Selection
{
    /// <summary>
    /// Base interface for all ray providers
    /// </summary>
    /// <see cref=""/>
    public interface IProvideRay
    {
        Ray GetRay();
    }
}