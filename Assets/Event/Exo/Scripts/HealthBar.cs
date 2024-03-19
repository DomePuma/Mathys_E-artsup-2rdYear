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

    private void ChangeHealthBar(int healthAmount)
    {
        healthBar.fillAmount -= healthAmount * 0.01f;
    }
}
