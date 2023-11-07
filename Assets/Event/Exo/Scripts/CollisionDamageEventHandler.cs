using UnityEngine;
using UnityEngine.Events;

public class CollisionDamageEventHandler : MonoBehaviour
{
    [SerializeField] private UnityEvent<int> _unityEvent;
    
    [SerializeField] private int _damage;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
           _unityEvent.Invoke(_damage);
        }
    }
}
