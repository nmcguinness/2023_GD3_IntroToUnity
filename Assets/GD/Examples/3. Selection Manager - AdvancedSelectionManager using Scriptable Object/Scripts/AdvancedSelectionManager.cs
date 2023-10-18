using GD.Selection;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Allows us to attach multiple responses to a selected object
/// </summary>
public class AdvancedSelectionManager : MonoBehaviour
{
    [SerializeField]
    [RequireInterface(typeof(ISelectionResponse))]
    private List<ScriptableObject> selectionResponses;

    //internal vars
    private IRayProvider rayProvider;

    private ISelector selector;
    private Transform currentSelection;

    private void Awake()
    {
        rayProvider = GetComponent<IRayProvider>();
        selector = GetComponent<ISelector>();
    }

    private void Update()
    {
        //set de-selected if we were previously selecting an appropriate (i.e., layer, distance) game object
        if (currentSelection != null)
        {
            foreach (ISelectionResponse selectionResponse in selectionResponses)
                selectionResponse.OnDeselect(currentSelection);
        }

        //create/get ray
        selector.Check(rayProvider.CreateRay());

        //get current selection (cast ray, do tag comparison)
        currentSelection = selector.GetSelection();

        //set selected
        if (currentSelection != null)
        {
            foreach (ISelectionResponse selectionResponse in selectionResponses)
                selectionResponse.OnSelect(currentSelection);
        }
    }
}