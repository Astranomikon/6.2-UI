using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Health { get; set; }
    public float MaxHealth { get; private set; }
    public float MinHealth { get; private set; }

    private void Start()
    {
        Health = 50;
        MaxHealth = 100;
        MinHealth = 0;
    }
}
