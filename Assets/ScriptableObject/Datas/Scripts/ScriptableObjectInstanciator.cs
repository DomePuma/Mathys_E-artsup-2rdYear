using System;
using UnityEditor;
using UnityEngine;

public class ScriptableObjectInstanciator : MonoBehaviour
{
    [SerializeField] private ScriptableObject _scriptableToInstanciante;

    private ScriptableObject ScriptableToInstantciante => _scriptableToInstanciante;

    private void Start()
    {
        if (_scriptableToInstanciante is Weapon scriptableWeapon)
        {
            scriptableWeapon.Attack();
            Debug.Log("Variable is Weapon");
        }

        _scriptableToInstanciante = Instantiate(_scriptableToInstanciante);
    }
}