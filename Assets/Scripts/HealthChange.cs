using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(SliderValue))]

public class HealthChange : MonoBehaviour
{
    [SerializeField] private Player _player;

    public event UnityAction Changed;

    private SliderValue _valueChanger;
    private float _damageValue = 10;
    private float _healthValue = 10;

    private void Start()
    {
        _valueChanger = GetComponent<SliderValue>();
    }

    public void ButtonDamage()
    {
        _player.TakeDamage(_damageValue);
        ChangeSliderValue();
    }

    public void ButtonHeal()
    {
        _player.TakeHeal(_healthValue);
        ChangeSliderValue();
    }

    private void ChangeSliderValue()
    {
        _valueChanger.SetTargetValue(_player.Health);
        Changed?.Invoke();
    }
}
