using System;
using System.Collections;
using UnityEngine;

public class CustomEvent : MonoBehaviour
{
    private Action<int> _customAction;

    private Func<string, float, int> _customFunc;
    private void Start()
    {
        _customAction += SignalCallback;
        
        _customFunc += FuncCallback;

        StartCoroutine(WaitForSignalCoroutine());
        
        IEnumerator WaitForSignalCoroutine()
        {
            yield return new WaitForSeconds(2);
            _customAction(1);
        }
    }

    private void SignalCallback(int occurence)
    {
        Debug.Log("Signal Receive");
    }

    private int FuncCallback(string name, float value)
    {
        return 0;
    }
}
