using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private SliderValueChanger _valueChanger;
    private float _changeValue = 10;

    public void OnButtonTakeDamageClick()
    {
        float value = _slider.value - _changeValue;

        if (value < _slider.minValue)
            value = _slider.minValue;

        _valueChanger.NewValue(_slider, value);
    }

    public void OnButtonTakeHealClick()
    {
        float value = _slider.value + _changeValue;

        if (value > _slider.maxValue)
            value = _slider.maxValue;

        _valueChanger.NewValue(_slider, value);
    }

    private void Start()
    {
        _valueChanger = GetComponent<SliderValueChanger>();
    }
}
