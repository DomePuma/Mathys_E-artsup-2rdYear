using UnityEngine;

public class OpenUIListener : MonoBehaviour
{
    [SerializeField] private GameObject[] _UIMenu;

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
        if(state)
        {
            _UIMenu[0].SetActive(state);
        }
        else
        {
            _UIMenu[0].SetActive(state);
            _UIMenu[1].SetActive(state);
            _UIMenu[2].SetActive(state);
        }
    }
}
