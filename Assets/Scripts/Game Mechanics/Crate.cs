using System;
using UnityEngine;

public class Crate : MonoBehaviour, IDamagable
{
    public int HealthAmount { get; set; }

    private void Awake()
    {
        HealthAmount = 2;
    }

    public void Damage(int damageAmount)
    {
        if (HealthAmount > 0)
        {
            HealthAmount -= damageAmount;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Arrow"))
        {
            Damage(1);
        }
    }
}
