using System;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableInput), menuName = "Events/Scriptable Input")]
public class ScriptableInput : ScriptableObject
{
    public Action OnPerformed;

    public void InvokeHit(InputAction.CallbackContext callbackContext)
    {
        if(callbackContext.performed)
        {
            OnPerformed?.Invoke();
        }
    }
}
