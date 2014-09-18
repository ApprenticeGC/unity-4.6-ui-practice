using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AdjustSliderValue : MonoBehaviour
{
    public Slider slider;

    public void ChangeValue(float inValue)
    {
        slider.value += inValue;
    }
}
