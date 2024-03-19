using UnityEngine;
using UnityEngine.Events;

public class ScriptableEventListener : MonoBehaviour
{
    [SerializeField] private ScriptableEvent _event;
    [SerializeField] private UnityEvent _callbacks;
    private void Start()
    {
        //_event.Event += InvokeEvents;
    }

    private void InvokeEvents()
    {
        _callbacks?.Invoke();
    }
}