using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableEventUI), menuName = "Events/Scriptable Event UI")]
public class ScriptableEventUI : ScriptableObject
{
    public static Action OpenUIAction;

    public void OpenUi()
    {
        OpenUIAction?.Invoke();
    }
}
