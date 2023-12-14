using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectFirstToggle : MonoBehaviour
{
    [SerializeField] Toggle toggle;
    private void OnEnable()
    {
        toggle.Select();
    }
}
