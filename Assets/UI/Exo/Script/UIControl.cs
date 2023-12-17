using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] public GameObject selection;
    [SerializeField] public GameObject inventory;
    [SerializeField] public GameObject parameter;

    bool _isSelectionActive;

    public void ActivationSelection()
    {
        if(!inventory.activeInHierarchy || !parameter.activeInHierarchy)
        {
            _isSelectionActive = !_isSelectionActive;
            selection.SetActive(_isSelectionActive);
        }
        else
        {
            _isSelectionActive = !_isSelectionActive;
        }
    }
}
