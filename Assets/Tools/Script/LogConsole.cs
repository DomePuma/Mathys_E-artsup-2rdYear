using UnityEditor;
using UnityEngine;

public class LogConsole : MonoBehaviour
{
    [MenuItem("Tools/Log Console")]
    static void DoSomething()
    {
        Debug.Log(Selection.activeGameObject.name);
    }
    
    [MenuItem("Tools/Log Console", true)]
    static bool ValidateDoSomething()
    {
        return Selection.activeGameObject != null;
    }
}