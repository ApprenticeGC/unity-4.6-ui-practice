using UnityEngine;
// New namespace for new UI
using UnityEngine.UI;
using System.Collections;

public class AutoValueChanging : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        StartCoroutine(Changing());
    }

    IEnumerator Changing()
    {
        while (true)
        {
            slider.value += Time.deltaTime;
            if (slider.value >= 1.0f)
            {
                slider.value = 0;
            }

            yield return new WaitForSeconds(0.4f);
        }
    }
}
