using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(SliderValue))]

public class HealthChangeEvent : MonoBehaviour
{
    [SerializeField] private Player _player;

    private UnityAction _changed;
    private SliderValue _valueChanger;
    private float _changeValue = 10;

    private void Start()
    {
        _valueChanger = GetComponent<SliderValue>();
    }

    public void TakeDamage()
    {
        _player.Health = Mathf.Max(_player.MinHealth, _player.Health - _changeValue);
        ChangeSliderValue();
    }

    public void TakeHeal()
    {
        _player.Health = Mathf.Min(_player.MaxHealth, _player.Health + _changeValue);
        ChangeSliderValue();
    }

    private void ChangeSliderValue()
    {
        _valueChanger.SetTargetValue(_player.Health);
        _changed += _valueChanger.NewValue;
        _changed?.Invoke();
        _changed -= _valueChanger.NewValue;
    }
}
