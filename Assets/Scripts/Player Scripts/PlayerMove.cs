using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   private float _horizontalMove;
   public float HorizontalMove => _horizontalMove;
   [SerializeField] private float _moveSpeed;
   private Vector3 _moveDirection;

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
      transform.position += _moveDirection;
      transform.position = new Vector2(Mathf.Clamp(transform.position.x, -10, 200), transform.position.y);
      //transform.Translate(transform.forward * _moveDirection);
   }
   
   
}
