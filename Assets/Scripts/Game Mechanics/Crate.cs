using System;
using UnityEngine;

public class Crate : MonoBehaviour, IDamagable
{
    public int _healthAmount { get; set; }

    private void Awake()
    {
        _healthAmount = 2;
    }

    public void Damage(int damageAmount)
    {
        if (_healthAmount > 0)
        {
            _healthAmount -= damageAmount;
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
