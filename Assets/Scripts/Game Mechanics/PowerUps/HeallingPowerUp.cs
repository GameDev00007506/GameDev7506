using System;
using UnityEngine;

public class HeallingPowerUp : MonoBehaviour, IPowerUp
{
    public static Action OnObjectCollided;
    public void Boost(GameObject obj)
    {
        obj.GetComponent<Health>().HealthAmount += 15;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out Health _health))
        {
            Boost(other.gameObject);
            OnObjectCollided?.Invoke();
            Destroy(gameObject, 0.1f);
        }
    }

   
}
