using System;
using UnityEngine;

public class SignalEmetter : MonoBehaviour
{
    
    public Action Signal;
    void Start()
    {
        Signal?.Invoke();
    }
}
