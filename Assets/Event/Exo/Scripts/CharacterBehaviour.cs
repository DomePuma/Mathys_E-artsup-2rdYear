using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class CharacterBehaviour : MonoBehaviour
{
    
    [SerializeField] private ScriptableEventInt _scriptableEventInt;
 
    [SerializeField] private int _health = 100;
    

    public int Health
    {
        get => _health;
        set
        {
            _health -= value;
        }
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
    
    private void TakeDamage(int damage)
    {
        _health -= damage;
        _scriptableEventInt.EventInt.Invoke(damage);
    }
}
