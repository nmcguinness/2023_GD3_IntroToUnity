using GD.Selection;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Allows us to attach multiple responses to a selected object
/// </summary>
public class MultipleSelectionManager : MonoBehaviour
{
    [SerializeField]
    private List<ISelectionResponse> selectionResponses;

    //internal vars
    private IRayProvider rayProvider;

    private ISelector selector;
    private Transform currentSelection;

    private void Awake()
    {
        rayProvider = GetComponent<IRayProvider>();
        selector = GetComponent<ISelector>();
    }
}