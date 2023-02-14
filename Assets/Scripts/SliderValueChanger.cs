using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueChanger : MonoBehaviour
{
    [SerializeField ] private Slider _slider;
    private float _deltaValue = 10;
    private Coroutine _coroutine;
    private float _targetValue;

    public void NewValue()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(ChangeValue());
    }

    public void SetTargetValue(float value)
    {
        _targetValue = value;
    }

    private IEnumerator ChangeValue()
    {
        while(_targetValue != _slider.value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _deltaValue * Time.deltaTime);
            yield return null;
        }
    }
}
