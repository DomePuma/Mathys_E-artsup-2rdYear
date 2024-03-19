using UnityEngine;
using UnityEngine.UI;

public class AutoSelectToggle : MonoBehaviour
{
    [SerializeField] private Toggle _firstToggleSelected;

    private void OnEnable() 
    {
        _firstToggleSelected.Select();
    }
}
