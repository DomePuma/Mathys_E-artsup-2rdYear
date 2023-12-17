using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "new_Deck", menuName = "Project/NewDeckOfCard")]
public class Deck : ScriptableObject
{
    [SerializeField] private List<Card> _deck;
    
    public List<Card> DeckOfCard => _deck;

    private string[] _deckPath;

    private void OnEnable()
    {
        _deck.Clear();
        _deckPath = AssetDatabase.FindAssets("t:Card");
        foreach (string deckPath in _deckPath)
        {
            _deck.Add(AssetDatabase.LoadAssetAtPath<Card>(AssetDatabase.GUIDToAssetPath(deckPath)));
        }
    }
}
