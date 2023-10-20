using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UIPrompt
{
    private static readonly Color DefaultColor = Color.black;

    [SerializeField]
    [TextArea(1, 2)]
    private string text = "";

    [SerializeField]
    [ColorUsage(true)]
    private Color color = DefaultColor;

    [SerializeField]
    [Range(0, 36)]
    private int size = 14;

    [SerializeField]
    private bool isBold;

    [SerializeField]
    private bool isItalic;

    [SerializeField, ReadOnly]
    private Vector2 dimensions;

    #region Constructors

    public UIPrompt(string text, int size)
        : this(text, size, DefaultColor, false, false)
    {
    }

    public UIPrompt(string text, int size, Color color)
        : this(text, size, color, false, false)
    {
    }

    public UIPrompt(string text, int size, Color color, bool isBold, bool isItalic)
    {
        Text = text;
        Size = size;
        Color = color;
        IsBold = isBold;
        IsItalic = isItalic;
    }

    #endregion Constructors

    public string Text { get => text; set => text = value.Trim(); }
    public int Size { get => size; set => size = value; }
    public Color Color { get => color; set => color = value; }
    public bool IsBold { get => isBold; set => isBold = value; }
    public bool IsItalic { get => isItalic; set => isItalic = value; }
    public Vector2 Dimensions { get => dimensions; }

    public void Initialize(GUIStyle guiStyle)
    {
        dimensions = guiStyle.CalcSize(new GUIContent(text));
    }

    public override string ToString()
    {
        return $"{(isItalic ? "<i>" : "")}{(isBold ? "<b>" : "")}<color=#{ColorUtility.ToHtmlStringRGBA(color)}><size={size}>{Text}</size></color>{(isBold ? "</b>" : "")}{(isItalic ? "</i>" : "")}";
    }
}

public class UIRichTextMultiPrompt : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Top left corner position (in pixels) of the first prompt")]
    private Vector2 startPosition = new Vector2(20, 20);

    [SerializeField]
    [Tooltip("X/Y separation (in pixels) between each prompt")]
    private Vector2 textOffset = new Vector2(0, 10);

    [SerializeField]
    private List<UIPrompt> prompts;

    private GUIStyle guiStyle;

    private void Start()
    {
        guiStyle = new GUIStyle();
        guiStyle.richText = true;

        InitializePrompts();
    }

    /// <summary>
    /// Sets dimensions based on text and GUIStyle
    /// </summary>
    private void InitializePrompts()
    {
        foreach (UIPrompt prompt in prompts)
            prompt.Initialize(guiStyle);
    }

    private void OnGUI()
    {
        var count = 0;
        foreach (UIPrompt prompt in prompts)
        {
            var corner = startPosition + textOffset * count++;
            GUI.Label(new Rect(corner, prompt.Dimensions), prompt.ToString(), guiStyle);
        }
    }
}