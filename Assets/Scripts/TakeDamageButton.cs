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
        _valueChanger.NewValue(_slider, _slider.value - _changeValue);
    }

    private void Start()
    {
        _valueChanger = GetComponent<SliderValueChanger>();
    }
}
