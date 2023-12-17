using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private ScriptableEventInt _eventInt;
    private UnityEngine.UI.Image _healthBar;

    private void Awake()
    {
        _healthBar = GetComponent<UnityEngine.UI.Image>();
    }

    private void Start()
    {
        _eventInt.EventInt += ChangeHealthBar;
    }

    private void ChangeHealthBar(int healthAmount)
    {
        _healthBar.fillAmount -= healthAmount * 0.01f;
    }
}
