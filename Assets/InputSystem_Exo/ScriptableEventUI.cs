using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableEventUI), menuName = "Events/Scriptable Event UI")]
public class ScriptableEventUI : ScriptableObject
{
    public static Action<bool> OpenUIAction;

    public void OpenUi(bool state)
    {
        OpenUIAction?.Invoke(state);
    }
}
