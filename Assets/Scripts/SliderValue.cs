using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HealthChange))]

public class SliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private HealthChange healthChange;
    private float _deltaValue = 10;
    private Coroutine _coroutine;
    private float _targetValue;

    private void Start()
    {
        healthChange = GetComponent<HealthChange>();
    }

    public void SetTargetValue(float value)
    {
        _targetValue = value;
        healthChange.Changed += NewValue;
    }

    private void NewValue()
    {
        Debug.Log(_targetValue);

        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
            healthChange.Changed -= NewValue;
        }

        _coroutine = StartCoroutine(ChangeValue());
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
