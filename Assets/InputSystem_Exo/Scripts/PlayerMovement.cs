using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _playerRigidbody;
    [SerializeField] private int _moveSpeed;
    [SerializeField] private Transform _playerOrientation;
    private Vector3 _moveDirection;
    private Vector2 _inputMoveValue;

    private void FixedUpdate() 
    {
        _moveDirection = _playerOrientation.forward * _inputMoveValue.y + _playerOrientation.right * _inputMoveValue.x;
        _playerRigidbody.AddForce(_moveDirection.normalized * _moveSpeed, ForceMode.Force);
    }

    public void ReadValueMove(InputAction.CallbackContext callbackContext)
    {
        _inputMoveValue = callbackContext.ReadValue<Vector2>();
    }
}
