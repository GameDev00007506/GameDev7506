using UnityEngine;
using UnityEngine.Events;

public class KeyWin : MonoBehaviour
{
    public UnityEvent OnGameFinished;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerMove player))
        {
            OnGameFinished.Invoke();
        }
    }
}
