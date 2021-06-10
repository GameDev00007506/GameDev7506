using UnityEngine;
using UnityEngine.Events;

public class Box : MonoBehaviour
{
    [SerializeField] private UnityEvent _onBoxDestroyed;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Arrow arrow))
        {
            _onBoxDestroyed.Invoke();
        }
    }
}
