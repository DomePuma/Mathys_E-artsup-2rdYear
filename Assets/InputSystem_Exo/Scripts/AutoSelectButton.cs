using UnityEngine;
using UnityEngine.UI;

public class AutoSelectButton : MonoBehaviour
{
    [SerializeField] private Button _firstButtonSelected;

    private void OnEnable() 
    {
        _firstButtonSelected.Select();
    }
}
