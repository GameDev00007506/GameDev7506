using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Arrow : MonoBehaviour
{
   private Rigidbody2D _rigidbody2D;
   [SerializeField] private float _speed = 10;

   private void Awake()
   {
      _rigidbody2D = GetComponent<Rigidbody2D>();
   }

   private void Update()
   {
      Fly();
   }

   public void Fly()
   {
      _rigidbody2D.velocity = Vector2.right * _speed;
   }
}
