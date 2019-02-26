using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class FlexibleUIText : FlexibleUI

{
    private TextMeshProUGUI text;
    public bool useMainFont = true;

    void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        base.Initialize();
    }

    protected override void OnSkinUI()
    {
        base.OnSkinUI();
        text.color =  flexibleUIData.textColor;
        if (useMainFont)
        {
            text.font = flexibleUIData.font;
        }
        
    }



}
