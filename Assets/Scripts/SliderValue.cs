using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private float _deltaValue = 10;
    private Coroutine _coroutine;

    private void Start()
    {
        _player.Changed += NewValue;
    }

    private void OnDestroy()
    {
        _player.Changed -= NewValue;
    }

    private void NewValue()
    {
        Debug.Log(_player.Health);

        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(ChangeValue());
    }

    private IEnumerator ChangeValue()
    {
        while(_player.Health != _slider.value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _player.Health, _deltaValue * Time.deltaTime);
            yield return null;
        }
    }
}
