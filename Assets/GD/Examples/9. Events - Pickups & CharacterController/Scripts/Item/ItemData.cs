using Sirenix.OdinInspector;
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Banana", menuName = "NMCG/Item")]
public class ItemData : ScriptableObject
{
    [Required]
    public string Name;

    [Min(-1000)]
    public int Value;

    [InlineButton("DoPress", "Press Me")]
    public AudioClip PickupClip;

    [PreviewField(50, Alignment = ObjectFieldAlignment.Left)]
    public Sprite WaypointIcon;

    private void DoPress()
    {
        Debug.Log("Pressing...");
    }
}