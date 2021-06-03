using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJump : MonoBehaviour
{
  [SerializeField] private Rigidbody2D _rigidbody2D;
  [SerializeField] private Vector2 _jumpForce;
  [SerializeField] private PlayerJumpTrigger _playerTrigger;
  [SerializeField] private UnityEvent _onPlayerJump;

  private void Update()
  {
    Jump();
  }

  private void Jump()
  {
    if (Input.GetButtonDown("Jump") && _playerTrigger.IsGrounded)
    {
      _rigidbody2D.AddForce(_jumpForce);
      _onPlayerJump?.Invoke();
    }
  }
}
