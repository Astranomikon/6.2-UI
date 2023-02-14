using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(SliderValueChanger))]

public class HealthChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private UnityEvent _changed;

    private SliderValueChanger _valueChanger;
    private float _changeValue = 10;

    public float TargetValue { get; private set; }

    private void Start()
    {
        _valueChanger = GetComponent<SliderValueChanger>();
    }

    public void TakeDamage()
    {
        float value = _slider.value - _changeValue;

        if (value < _slider.minValue)
            value = _slider.minValue;

        _valueChanger.SetTargetValue(value);
        _changed?.Invoke();
    }

    public void TakeHeal()
    {
        float value = _slider.value + _changeValue;

        if (value > _slider.maxValue)
            value = _slider.maxValue;

        _valueChanger.SetTargetValue(value);
        _changed?.Invoke();
    }
}
