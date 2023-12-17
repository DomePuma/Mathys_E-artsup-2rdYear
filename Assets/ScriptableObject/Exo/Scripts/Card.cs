using System;
using UnityEditor;
using UnityEngine;

public class Card : ScriptableObject
{
    private enum CardColor
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades,
    }
    private enum CardValue
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace,
    }

    private Card[] _deckCards;
    [SerializeField] private CardColor _cardColor;
    [SerializeField] private CardValue _cardValue;

    [MenuItem("CardProject/GenerateDeck")]
    private static void GenerationDeck()
    {
        AssetDatabase.DeleteAsset("Assets/ScriptableObject/Exo/Deck");
        AssetDatabase.CreateFolder("Assets/ScriptableObject/Exo", "Deck");
        Debug.Log("GenerateDeck");
        foreach (CardColor cardColor in Enum.GetValues(typeof(CardColor)))
        {
            AssetDatabase.CreateFolder("Assets/ScriptableObject/Exo/Deck", cardColor.ToString());
            foreach (CardValue cardValue in Enum.GetValues(typeof(CardValue)))
            {
                Card newCardAsset = ScriptableObject.CreateInstance<Card>();
                newCardAsset._cardColor = cardColor;
                newCardAsset._cardValue = cardValue;
                AssetDatabase.CreateAsset(newCardAsset, "Assets/ScriptableObject/Exo/Deck/" + cardColor.ToString() + "/" + cardColor.ToString() + "_" + cardValue + ".asset");
            }
        }  
    }
}
