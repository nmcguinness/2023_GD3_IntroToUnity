using UnityEngine;

namespace GD.Selection
{
    public class VertexDisplacementSelectionResponse : MonoBehaviour, ISelectionResponse
    {
        [SerializeField]
        private Material material;

        private int distortionCentreID;

        // Start is called before the first frame update
        private void Start()
        {
            distortionCentreID = Shader.PropertyToID("_Distortion_Centre");
        }

        public void OnSelect(Transform transform, RaycastHit hitInfo)
        {
            if (material == null)
                return;

            material.SetVector(distortionCentreID, hitInfo.point);
        }

        public void OnDeselect(Transform transform)
        {
        }

        public void OnSelect(Transform transform)
        {
            throw new System.NotImplementedException();
        }
    }
}