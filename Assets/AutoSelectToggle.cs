using UnityEngine;
using UnityEngine.UI;

public class AutoSelectToggle : MonoBehaviour
{
    [SerializeField] private Toggle firstToggleSelected;

    public void OnEnable() 
    {
        firstToggleSelected.Select();
    }
}
