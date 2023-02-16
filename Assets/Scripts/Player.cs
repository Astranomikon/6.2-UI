using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Player : MonoBehaviour
{
    public float Health { get; private set; }
    public float MaxHealth { get; private set; }
    public float MinHealth { get; private set; }

    private void Start()
    {
        Health = 50;
        MaxHealth = 100;
        MinHealth = 0;
    }
    public void TakeDamage(float damage)
    {
        Health = Mathf.Max(MinHealth, Health - damage);    
    }

    public void TakeHeal(float heal)
    {
        Health = Mathf.Min(MaxHealth, Health + heal);
    }
}
