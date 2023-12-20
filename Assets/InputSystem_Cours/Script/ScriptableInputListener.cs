using System;
using UnityEngine;

public class ScriptableInputListener : MonoBehaviour
{
    public static Action HitAction;
    [SerializeField] private ScriptableInput _scriptableInput;
    
    private void OnEnable() 
    {
        _scriptableInput.OnPerformed += InvokeEvent;
    }

    private void OnDisable() 
    {
        _scriptableInput.OnPerformed -= InvokeEvent;
    }
    
    private void InvokeEvent()
    {
        HitAction?.Invoke();
    }
}
