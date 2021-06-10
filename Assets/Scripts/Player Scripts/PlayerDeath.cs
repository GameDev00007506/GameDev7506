using UnityEngine;
using UnityEngine.Events;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private UnityEvent _onPlayerDead;
    public UnityEvent OnPlayerDead => _onPlayerDead;

    public void PlayerIsDead()
    {
        _onPlayerDead.Invoke();
    }

    public void CheckDeath()
    {
        if (this.gameObject.transform.position.y < -10)
        {
            PlayerIsDead();
        }
    }
}
