using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _playerPosition;
    
    private Vector3 _cameraPosition;
    void LateUpdate()
    {
        _cameraPosition = transform.position;

        _cameraPosition.x = _playerPosition.position.x;
        
        transform.position = _cameraPosition;
    }
}
