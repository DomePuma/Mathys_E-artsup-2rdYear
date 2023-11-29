using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AutoSelectButton : MonoBehaviour
{
    [SerializeField] private Button firstButtonSelected;

    public void OnEnable() 
    {
        firstButtonSelected.Select();
    }
}
