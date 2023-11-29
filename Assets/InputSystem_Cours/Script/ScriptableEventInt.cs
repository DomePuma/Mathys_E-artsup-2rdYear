using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableEventInt), menuName = "Events/Scriptable Event Int")]
public class ScriptableEventInt : ScriptableObject
{
    public Action<int> EventInt;
}
