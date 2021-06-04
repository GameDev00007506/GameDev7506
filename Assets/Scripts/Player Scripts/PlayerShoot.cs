using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerShoot : MonoBehaviour
{
   [SerializeField] private Transform _arrowPosition;
   [SerializeField] private UnityEvent _onPlayerShoot;

   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         Shoot();
      }
   }

   public void Shoot()
   {
      _onPlayerShoot.Invoke();
      GameObject arrow = ObjectPool.Instance.GetPooledObject();

      if (arrow != null)
      {
         arrow.transform.position = _arrowPosition.position;
         arrow.SetActive(true);
      }
   }
}
