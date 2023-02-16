using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Player : MonoBehaviour
{
    public float Health { get; private set; }
    public float MaxHealth { get; private set; }
    public float MinHealth { get; private set; }

    public event UnityAction Changed;

    private float _damageValue = 10;
    private float _healthValue = 10;

    private void Start()
    {
        Health = 50;
        MaxHealth = 100;
        MinHealth = 0;
    }
    public void TakeDamage()
    {
        Health = Mathf.Max(MinHealth, Health - _damageValue);
        Changed?.Invoke();
    }

    public void TakeHeal()
    {
        Health = Mathf.Min(MaxHealth, Health + _healthValue);
        Changed?.Invoke();
    }
}
