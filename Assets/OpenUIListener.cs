using UnityEngine;

public class OpenUIListener : MonoBehaviour
{
    [SerializeField] GameObject UIMenu;
    private bool _uiState;
    private void OnEnable() 
    {
        ScriptableEventUI.OpenUIAction += OpenUI;
    }
    private void OnDisable() 
    {
        ScriptableEventUI.OpenUIAction -= OpenUI;
    }

    private void OpenUI(bool state)
    {
        UIMenu.SetActive(state);
    }
}
