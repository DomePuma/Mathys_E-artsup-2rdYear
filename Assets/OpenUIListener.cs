using UnityEngine;

public class OpenUIListener : MonoBehaviour
{
    [SerializeField] GameObject[] UIMenu;
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
            UIMenu[0].SetActive(state);
        }
        else
        {
            UIMenu[0].SetActive(state);
            UIMenu[1].SetActive(state);
            UIMenu[2].SetActive(state);
        }
    }
}
