using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

[CreateAssetMenu(menuName = "Flexible UI Data")]
public class FlexibleUIData : ScriptableObject
{

    [Header("Button Colors")]
    public ColorBlock buttonColorBlock;

    [Header("Panel Color")]
    public Color imageColor;

    [Header("Slider Colors")]
    public ColorBlock sliderColorBlock;

    [Header("Text Attributes")]
    public TMP_FontAsset font;
    public Color32 textColor;
}
