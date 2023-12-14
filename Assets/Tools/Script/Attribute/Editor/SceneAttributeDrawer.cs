using UnityEngine;
using UnityEditor;
using System.IO;

[CustomPropertyDrawer(typeof(SceneAttribute))]
public class SceneAttributeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty serializedProperty, GUIContent label) 
    {
        string[] scenesNameArray = new string[EditorBuildSettings.scenes.Length];
        if(serializedProperty.propertyType == SerializedPropertyType.Integer)
        {
            for(int i = 0; i < EditorBuildSettings.scenes.Length; i++)
            {
                scenesNameArray[i] = Path.GetFileNameWithoutExtension(EditorBuildSettings.scenes[i].path);
            }
            serializedProperty.intValue = EditorGUI.Popup(position, label.text, serializedProperty.intValue, scenesNameArray);
        }
        if(serializedProperty.propertyType == SerializedPropertyType.String)
        {
            for(int i = 0; i < EditorBuildSettings.scenes.Length; i++)
            {
                scenesNameArray[i] = Path.GetFileNameWithoutExtension(EditorBuildSettings.scenes[i].path);
            }
            serializedProperty.intValue = EditorGUI.Popup(position, label.text, serializedProperty.intValue, scenesNameArray);   
        }
        if(EditorGUI.DropdownButton(position, GUIContent.none, FocusType.Passive) == true)
        {
            serializedProperty.intValue++;
        }
    }
}