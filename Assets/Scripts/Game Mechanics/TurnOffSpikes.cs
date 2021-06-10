using System;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffSpikes : MonoBehaviour
{
    [SerializeField] private List<HazardEnemy> _enemies;


    public void TurnOffHazards()
    {
        foreach (var enemy in _enemies)
        {
            enemy.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerMove player))
        {
            TurnOffHazards();
        }
    }
}
