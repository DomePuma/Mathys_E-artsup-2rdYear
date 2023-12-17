using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] private GameObject selection;
    [SerializeField] private GameObject inventory;
    [SerializeField] private GameObject parameter;

    private bool _isSelectionActive;

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
