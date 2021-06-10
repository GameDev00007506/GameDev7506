using Unity.Mathematics;
using UnityEngine;

public class SpawnPowerUp : MonoBehaviour
{
    [SerializeField] private HeallingPowerUp _powerUp;

    public void SpawnRandomPowerUp(Transform spawnPlace)
    {
        Instantiate(_powerUp, spawnPlace.position, quaternion.identity);
    }
}
