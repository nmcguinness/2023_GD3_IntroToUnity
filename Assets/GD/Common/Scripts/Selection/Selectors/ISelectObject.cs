using UnityEngine;

namespace GD.Selection
{
    public interface ISelectObject
    {
        //check for a hit
        void Check(Ray ray);

        //get the transform of hit thing
        Transform GetSelection();

        //get specifics of where on thing we hit (normals etc)
        RaycastHit GetHitInfo();
    }
}