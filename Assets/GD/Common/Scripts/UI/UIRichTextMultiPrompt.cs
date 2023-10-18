using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UIPrompt
{
    [SerializeField]
    [TextArea(1, 3)]
    private string text;

    [SerializeField]
    [Range(8, 18)]
    private int fontSize;

    [SerializeField]
    private bool isBold;

    //italic, color

    public UIPrompt(string text, int fontSize) : this(text, fontSize, false)
    {
    }

    public UIPrompt(string text, int fontSize, bool isBold)
    {
        Text = text;
        FontSize = fontSize;
        IsBold = isBold;
    }

    public string Text { get => text; set => text = value.Trim(); }
    public int FontSize { get => fontSize; set => fontSize = value; }
    public bool IsBold { get => isBold; set => isBold = value; }
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