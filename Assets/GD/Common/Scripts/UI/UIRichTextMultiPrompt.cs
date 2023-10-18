using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UIPrompt
{
    #region Fields

    [SerializeField]
    [TextArea(1, 3)]
    private string text;

    [SerializeField]
    [Range(8, 18)]
    private int fontSize;

    [SerializeField]
    private bool isBold;

    [SerializeField]
    [ReadOnly]
    private Vector2 dimensions;

    [SerializeField]
    [ReadOnly]
    private string promptAsString;

    #endregion Fields

    #region Properties

    public string Text { get => text; set => text = value.Trim(); }

    public int FontSize { get => fontSize; set => fontSize = value; }
    public bool IsBold { get => isBold; set => isBold = value; }
    public Vector2 Dimensions { get => dimensions; }
    public string PromptAsString { get => promptAsString; }

    #endregion Properties

    #region Constructors

    public UIPrompt(string text, int fontSize) : this(text, fontSize, false)
    {
    }

    public UIPrompt(string text, int fontSize, bool isBold)
    {
        Text = text;
        FontSize = fontSize;
        IsBold = isBold;
    }

    #endregion Constructors

    public void Initialize(GUIStyle guiStyle)
    {
        dimensions = guiStyle.CalcSize(new GUIContent(text));
        GetPromptAsString();
    }

    public void GetPromptAsString()
    {
        //TODO - add code to wrap bold and italic, set size, and color
        promptAsString = $"";
    }
}

/// <summary>
/// Provides the designer/developer with the ability to show multiple lines
/// of text on the GUI where each line has a separate format (i.e., color, size, b/i/u)
/// </summary>
/// <see cref="GD.UIRichTextPrompt"/>
/// <seealso cref="https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/StyledText.html"/>
/// <seealso cref="https://docs.unity3d.com/ScriptReference/GUIStyle-margin.html"/>
public class UIRichTextMultiPrompt : MonoBehaviour
{
    [Header("Position & Offset")]
    [SerializeField]
    private Vector2 startPosition = new Vector2(20, 20);

    [SerializeField]
    private Vector2 textOffset = new Vector2(0, 20);

    [Header("Prompts")]
    [SerializeField]
    private List<UIPrompt> prompts;

    private GUIStyle guiStyle;

    private void Start()
    {
        guiStyle = new GUIStyle();
        guiStyle.richText = true;

        //set dimensions on all UIPrompt
        InitializePrompts(guiStyle);
    }

    private void InitializePrompts(GUIStyle guiStyle)
    {
        foreach (var prompt in prompts)
            prompt.Initialize(guiStyle);
    }

    private void OnGUI()
    {
        var numberOfLines = 0;
        foreach (var prompt in prompts)
        {
            //calc its corner
            var corner = startPosition + numberOfLines * textOffset;
            //calc its dims
            var dimensions = guiStyle.CalcSize(new GUIContent(prompt.Text));
            //calc its rect
            var textPosition = new Rect(corner.x, corner.y, dimensions.x, dimensions.y);
            GUI.Label(textPosition, prompt.Text, guiStyle);
            numberOfLines++;
        }
    }
}