using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Arrow : MonoBehaviour
{
   private PlayerMove _player;
   private Rigidbody2D _rigidbody2D;
   [SerializeField] private float _speed = 10;
   private Vector2 _moveVector;

   private void OnEnable()
   {
      SetDirection();
   }

   private void Awake()
   {
      _rigidbody2D = GetComponent<Rigidbody2D>();
      _player = FindObjectOfType<PlayerMove>();
   }

   public void SetDirection()
   {
      _moveVector = _player.transform.right;
      transform.eulerAngles = _player.transform.eulerAngles + (Vector3.up * -180);
   }

   private void Update()
   {
      Fly();
   }

   public void Fly()
   {
      _rigidbody2D.velocity = _moveVector * _speed;
   }
}
