using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private ScriptableEventInt EventInt;
    private UnityEngine.UI.Image healthBar;

    private void Awake()
    {
        healthBar = GetComponent<UnityEngine.UI.Image>();
    }

    private void Start()
    {
        EventInt.EventInt += ChangeHealthBar;
    }

    public void OnEnableCharacter()
    {
        
    }
    
    private void ChangeHealthBar(int healthAmounth)
    {
        healthBar.fillAmount -= healthAmounth * 0.01f;
    }
}
