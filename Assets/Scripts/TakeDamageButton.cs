using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SliderValueChanger))]

public class TakeDamageButton : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private SliderValueChanger _valueChanger;
    private float _changeValue = 10;

    public void OnButtonClick()
    {
        float value = _slider.value - _changeValue;

        if (value < _slider.minValue)
            value = _slider.minValue;

        _valueChanger.NewValue(_slider, value);
    }

    private void Start()
    {
        _valueChanger = GetComponent<SliderValueChanger>();
    }
}
