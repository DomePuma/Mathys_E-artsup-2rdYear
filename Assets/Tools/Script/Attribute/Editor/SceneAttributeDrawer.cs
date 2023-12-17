using UnityEngine;
using UnityEditor;
using System.IO;
using System;

[CustomPropertyDrawer(typeof(SceneAttribute))]
public class SceneAttributeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty serializedProperty, GUIContent label) 
    {
        
        string[] sceneNameArray = Array.ConvertAll(EditorBuildSettings.scenes, (EditorBuildSettingsScene scene) =>
        {
            return Path.GetFileNameWithoutExtension(scene.path);
        });

        if (serializedProperty.propertyType == SerializedPropertyType.Integer)
        {
            using (new EditorGUI.PropertyScope(position, label, serializedProperty))
            {
                serializedProperty.intValue = EditorGUI.Popup(position, label.text, serializedProperty.intValue, sceneNameArray);
            }
        }
        else if (serializedProperty.propertyType == SerializedPropertyType.String)
        {
            using (new EditorGUI.PropertyScope(position, label, serializedProperty))
            {
                int sceneIndex = Array.IndexOf(sceneNameArray, serializedProperty.stringValue);
                sceneIndex = EditorGUI.Popup(position, label.text, sceneIndex, sceneNameArray);
                serializedProperty.stringValue = sceneNameArray[sceneIndex];
            }
        }
        else
        {
            using (new EditorGUI.PropertyScope(position, label, serializedProperty))
            {
                GUI.color = Color.red;
                EditorGUI.LabelField(position, "Error : Unvailable property type.");
            }
        }
    }
}