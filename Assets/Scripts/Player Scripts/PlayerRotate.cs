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

    /// <summary>
    /// Checks Player Input and Rotates
    /// </summary>
    public void CheckPlayerInput()
    {
        if (_playerMove.HorizontalMove > 0)
        {
            RotatePlayer(yScale);
        }
        
        else if (_playerMove.HorizontalMove < 0)
        {
            RotatePlayer(-yScale);
        }
    }


}
