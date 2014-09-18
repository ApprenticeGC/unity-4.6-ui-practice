using UnityEngine;
using System;
using System.Collections;

public class SetTextValue : MonoBehaviour
{
    public UnityEngine.UI.Text text;

    public void SetText(float inValue)
    {
        float adjustedFloatValue = inValue * 100.0f;
        string adjustedValue = String.Format("{0:F2}", adjustedFloatValue);
        text.text = adjustedValue;
    }
}
