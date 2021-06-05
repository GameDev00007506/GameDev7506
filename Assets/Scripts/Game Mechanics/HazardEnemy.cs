using System;
using UnityEngine;

public class HazardEnemy : MonoBehaviour, IEnemy
{
    public static Action OnObjectDamaged;
    public void ApplyDamage(GameObject player)
    {
        player.GetComponent<Health>().Damage(20);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out Health _health))
        {
            ApplyDamage(other.gameObject);
            OnObjectDamaged?.Invoke();
        }
    }
}
