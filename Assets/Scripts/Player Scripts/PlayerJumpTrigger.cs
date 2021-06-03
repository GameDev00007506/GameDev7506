using System;
using UnityEngine;

public class PlayerJumpTrigger : MonoBehaviour
{
   private bool _isGrounded;

   public bool IsGrounded => _isGrounded;

   private void OnCollisionStay2D(Collision2D other)
   {
      if (other.gameObject.CompareTag("Ground"))
      {
         _isGrounded = true;
      }
   }

   private void OnCollisionExit2D(Collision2D other)
   {
      if (other.gameObject.CompareTag("Ground"))
      {
         _isGrounded = false;
      }
   }
}
