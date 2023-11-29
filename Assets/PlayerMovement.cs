using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private int moveSpeed;
    [SerializeField] private Transform playerOrientation;
    Vector3 _moveDirection;
    Vector2 _inputMoveValue;

    private void FixedUpdate() 
    {
        Move();        
    }

    public void ReadValueMove(InputAction.CallbackContext callbackContext)
    {
        _inputMoveValue = callbackContext.ReadValue<Vector2>();
    }
    private void Move()
    {
        
        _moveDirection = playerOrientation.forward * _inputMoveValue.y + playerOrientation.right * _inputMoveValue.x;
        playerRigidbody.AddForce(_moveDirection.normalized * moveSpeed, ForceMode.Force);
    }
}
