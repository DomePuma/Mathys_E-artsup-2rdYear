using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableObject), menuName = "Events/Scriptable Event")]
public class ScriptableEvent : ScriptableObject
{
    public Action<int> Event;
}