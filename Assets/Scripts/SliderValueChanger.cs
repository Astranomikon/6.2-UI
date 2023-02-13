using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueChanger : MonoBehaviour
{
    private Slider _slider;
    private float _deltaValue = 5;
    Coroutine coroutine;

    public void NewValue(Slider slider, float value)
    {
        _slider = slider;

        if (coroutine != null)
            StopCoroutine(coroutine);

        coroutine = StartCoroutine(ChangeValue(value));
    }

    private IEnumerator ChangeValue(float value)
    {
        while (true)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, value, _deltaValue * Time.deltaTime);
            yield return null;
        }
    }
}
