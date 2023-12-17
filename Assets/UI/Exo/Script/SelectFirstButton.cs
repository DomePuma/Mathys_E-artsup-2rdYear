using UnityEngine;
using UnityEngine.UI;

public class SelectFirstButton : MonoBehaviour
{
    [SerializeField] private Button button;
    
    private void OnEnable()
    {
        button.Select();
    } 
}
