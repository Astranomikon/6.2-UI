using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SliderValueChanger))]

public class TakeHealButton : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private SliderValueChanger _valueChanger;
    private float _changeValue = 10;

    public void OnButtonClick()
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
