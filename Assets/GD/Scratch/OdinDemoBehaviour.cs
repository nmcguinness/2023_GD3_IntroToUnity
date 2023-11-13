using GD;
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Something
{
    public int id; public string name;
}

[Flags]
public enum TeamType
{
    None = 0,
    Aggressors = 1,
    Ambushers = 2,
    Saboteurs = 4,
    Spies = 8,

    //bitwise OR
    All = Aggressors | Spies | Saboteurs | Ambushers
}

public class OdinDemoBehaviour : MonoBehaviour
{
    [TabGroup("tab1", "UI", SdfIconType.Arrow90degUp)]
    [SerializeField, ColorPalette]
    private Color uiPlayBtnColor;

    [TabGroup("tab1", "Firearms", SdfIconType.BadgeVoFill)]
    [MinMaxSlider(-20, 20)]
    public Vector2 explosionRadius;

    [TabGroup("tab1", "Firearms")]
    [Unit(Units.Second)]
    public int someThing;

    [TabGroup("tab1", "Menu", SdfIconType.BatteryHalf)]
    [PreviewField(50, Alignment = ObjectFieldAlignment.Left)]
    public Sprite uiIcon;

    public bool isArmed;

    [ShowIf("isArmed")]
    public int rifleClip;

    [ShowIf("isArmed")]
    public int handgunClip;

    public bool isGroup;

    [ShowIf("isGroup")]
    [FoldoutGroup("Team Setup", Expanded = true)]
    [EnumToggleButtons]
    public TeamType teamType;

    [ShowIf("isGroup")]
    [FoldoutGroup("Team Setup")]
    [EnumToggleButtons]
    public TeamType teamType2;

    [ShowIf("isGroup")]
    [FoldoutGroup("Team Setup")]
    [EnumToggleButtons]
    public TeamType teamType3;

    [ShowIf("isGroup")]
    [FoldoutGroup("Team Setup")]
    [EnumPaging]
    public AttackType attackType;

    // [TableList]
    public List<Something> somethings = new();
}