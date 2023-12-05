using UnityEngine;
using UnityEngine.UI;

public class AutoSelectButton : MonoBehaviour
{
    [SerializeField] private Button firstButtonSelected;

    public void OnEnable() 
    {
        firstButtonSelected.Select();
    }
}
