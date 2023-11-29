using System;
using UnityEngine;

public class ScriptableInputListener : MonoBehaviour
{
    [SerializeField] ScriptableInput scriptableInput;
    public static Action HitAction;
    private void OnEnable() 
    {
        scriptableInput.OnPerformed += InvokeEvent;
    }

    private void OnDisable() 
    {
        scriptableInput.OnPerformed -= InvokeEvent;
    }
    
    private void InvokeEvent()
    {
        HitAction?.Invoke();
    }
}
