using UnityEngine;
public class CharacterBehaviour : MonoBehaviour
{
    [SerializeField] private ScriptableEventInt _scriptableEventInt;
 
    [SerializeField] private int _health = 100;
    
    public int Health
    {
        get => _health;
        set => _health -= value;
    }
    
    private void OnEnable() 
    {
        ScriptableInputListener.HitAction += OnHit;
    }
    
    private void TakeDamage(int damage)
    {
        _health -= damage;
        _scriptableEventInt.EventInt.Invoke(damage);
    }
    
    public void OnHit()
    {
        TakeDamage(10);
    }
    
}