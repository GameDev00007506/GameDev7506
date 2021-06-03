using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
   [SerializeField] private PlayerMove _playerMove;
   [SerializeField] private Animator _animator;

   public void RunAnimations(bool runningState)
   {
      _animator.SetBool("IsRunning", runningState);
   }

   private void Update()
   {
      CheckPlayerSpeed();
   }

   /// <summary>
   /// Check Player Speed and Make Run Animations
   /// </summary>
   public void CheckPlayerSpeed()
   {
      if (_playerMove.HorizontalMove != 0)
      {
         RunAnimations(true);
      }
      else
      {
         RunAnimations(false);
      }
   }

}
