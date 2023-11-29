using UnityEngine;

public class OpenUIListener : MonoBehaviour
{
    [SerializeField] GameObject UIMenu;
    private void OnEnable() 
    {
        ScriptableEventUI.OpenUIAction += OpenUI;
    }
    private void OnDisable() 
    {
        ScriptableEventUI.OpenUIAction -= OpenUI;
    }

    private void OpenUI()
    {
        UIMenu.SetActive(true);
    }
}
