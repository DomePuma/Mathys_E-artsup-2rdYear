using UnityEngine;
public class CharacterBehaviour : MonoBehaviour
{
    [SerializeField] private ScriptableEventInt _scriptableEventInt;
 
    [SerializeField] private int _health = 100;

    [SerializeField] private int _damageTest;
    public int Health
    {
        get => _health;
        set => _health -= value;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(_damageTest);
        }
    }
    
    private void TakeDamage(int damage)
    {
        _health -= damage;
        _scriptableEventInt.EventInt.Invoke(damage);
    }
}
