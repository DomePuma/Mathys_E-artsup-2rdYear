using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CustomEditorComponent))]
public class CustomEditorComponentEditor : Editor
{
    SerializedProperty nameProp;
    SerializedProperty statsProp;
    SerializedProperty sceneIndexProp;
    SerializedProperty sceneNameProp;

    private void OnEnable() 
    {
        nameProp = serializedObject.FindProperty("_sampleText");
        statsProp = serializedObject.FindProperty("_stats");
        sceneIndexProp = serializedObject.FindProperty("_sceneIndex");
        sceneNameProp = serializedObject.FindProperty("_sceneName");
    }
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.LabelField(nameProp.stringValue);
        
        using (new GUILayout.HorizontalScope("box"))
        {
            if(GUILayout.Button("-1"))
            {
                sceneIndexProp.intValue--;
            }
            if(GUILayout.Button("+1"))
            {
                sceneIndexProp.intValue++;
            }
        }
        
        nameProp.serializedObject.ApplyModifiedProperties();
        statsProp.serializedObject.ApplyModifiedProperties();
        sceneIndexProp.serializedObject.ApplyModifiedProperties();
    }
}
