using UnityEngine;

namespace GD
{
    public class SimpleSelectionManager : MonoBehaviour
    {
        [SerializeField]
        private string selectableTag = "Selectable";

        private Camera mainCamera;

        //local vars
        private Ray ray;

        private Transform oldSelection;
        private Color oldColor;

        private void Awake()
        {
            selectableTag = selectableTag.Trim();
            mainCamera = Camera.main;
        }

        // Update is called once per frame
        private void Update()
        {
            //get a line(ray) from camera to mouse position into world
            ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            //prepare an object to store hit results
            RaycastHit hitInfo = new RaycastHit();

            //work out what was hit/moused over
            if (Physics.Raycast(ray, out hitInfo))
            {
                //get transform of hit thing
                var currentSelection = hitInfo.transform;

                //did we hit something interesting?
                if (currentSelection.CompareTag(selectableTag))
                {
                    var renderer
                        = currentSelection.gameObject.GetComponent<MeshRenderer>();
                    if (renderer != null)
                    {
                        oldColor = renderer.material.color;
                        renderer.material.color = Color.magenta;
                    }
                    if (oldSelection != null && oldSelection != currentSelection)
                    {
                        oldSelection.gameObject.GetComponent<MeshRenderer>().material.color
                            = oldColor;
                    }
                    oldSelection = currentSelection;
                }
            }
        }
    }
}

/*
 namespace GD
{
    public class SimpleSelectionManager : MonoBehaviour
    {
        [SerializeField]
        private string selectableTag = "Selectable";

        private Camera mainCamera;

        //local vars
        private Ray ray;

        private void Awake()
        {
            selectableTag = selectableTag.Trim();
            mainCamera = Camera.main;
        }

        // Update is called once per frame
        private void Update()
        {
            //get a line(ray) from camera to mouse position into world
            ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            //prepare an object to store hit results
            RaycastHit hitInfo = new RaycastHit();

            //work out what was hit/moused over
            if (Physics.Raycast(ray, out hitInfo))
            {
                //get transform of hit thing
                var currentSelection = hitInfo.transform;

                //did we hit something interesting?
                if (currentSelection.CompareTag(selectableTag))
                {
                    //change the moused over thing
                    Debug.Log(currentSelection.position.ToString());
                }
            }
        }
    }
}

 */