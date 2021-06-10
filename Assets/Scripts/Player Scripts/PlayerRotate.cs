using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private PlayerMove _playerMove;
    
    [SerializeField] private float yScale = 0.8f;

    private void Update()
    {
        CheckPlayerInput();
    }
    public void RotatePlayer(float xScale)
    {
        transform.localScale = new Vector2(xScale, yScale);
    }

    public void Rotate()
    {
        if (_playerMove.HorizontalMove > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (_playerMove.HorizontalMove < 0)
        {
            transform.eulerAngles = new Vector2(0, -180); 
        }
    }

    /// <summary>
    /// Checks Player Input and Rotates
    /// </summary>
    public void CheckPlayerInput()
    {
        /*if (_playerMove.HorizontalMove > 0)
        {
            RotatePlayer(yScale);
        }
        
        else if (_playerMove.HorizontalMove < 0)
        {
            RotatePlayer(-yScale);
        }*/
        Rotate();
    }


}
