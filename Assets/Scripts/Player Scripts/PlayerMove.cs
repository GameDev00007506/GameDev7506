using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   [SerializeField] private float _horizontalMove;
   public float HorizontalMove => _horizontalMove;
   [SerializeField] private float _moveSpeed;
   private Vector2 _moveDirection;

   private void Update()
   {
      Move();
   }

   /// <summary>
   /// Player Movement
   /// </summary>
   private void Move()
   {
      _horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed;
      _moveDirection = new Vector2(_horizontalMove, 0);
      transform.Translate(_moveDirection);
   }
   
   
}
