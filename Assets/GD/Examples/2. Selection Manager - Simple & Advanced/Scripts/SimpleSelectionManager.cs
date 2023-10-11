using UnityEngine;

namespace GD
{
    public class SimpleSelectionManager : MonoBehaviour
    {
        [SerializeField]
        private string selectableTag = "Selectable";

        private Camera mainCamera;
        private HighlightResponseController highlightResponseController;

        //local vars
        private Ray ray;

        private Transform oldSelection;

        [SerializeField]
        private AudioClip onMouseOverAudio;

        [SerializeField]
        [Range(0, 1)]
        private float clipVolume = 1;

        [SerializeField]
        private GameObject highlightResponse;

        [SerializeField]
        private Vector3 positionOffset;

        private void Awake()
        {
            selectableTag = selectableTag.Trim();
            mainCamera = Camera.main;

            //get controller
            highlightResponseController
                = highlightResponse.GetComponent<HighlightResponseController>();

            //hide the controller
            highlightResponseController.SetActive(false);
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
                    //highlight the object
                    highlightResponseController.SetActive(true);
                    highlightResponseController.SetPosition(currentSelection.position + positionOffset);

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

        private Transform oldSelection;

        [SerializeField]
        private AudioClip onMouseOverAudio;

        [SerializeField]
        [Range(0, 1)]
        private float clipVolume = 1;

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
                    if (currentSelection != oldSelection)
                    {
                        AudioSource.PlayClipAtPoint(onMouseOverAudio,
                            currentSelection.position, clipVolume);
                    }

                    oldSelection = currentSelection;
                }
            }
        }
    }
}
*/
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
                    if (oldSelection != null && oldSelection != currentSelection)
                    {
                        oldSelection.gameObject.GetComponent<MeshRenderer>().material.color
                            = oldColor;
                    }

                    var renderer
                        = currentSelection.gameObject.GetComponent<MeshRenderer>();
                    if (renderer != null)
                    {
                        oldColor = renderer.material.color;
                        renderer.material.color = Color.magenta;
                    }

                    oldSelection = currentSelection;
                }
            }
        }
    }
}
*/
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