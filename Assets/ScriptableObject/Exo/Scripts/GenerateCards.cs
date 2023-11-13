using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenerateCards : MonoBehaviour
{
    [SerializeField] private List<Card> _handOfCards;
    [SerializeField] private int _numberOfCardsToDraw;
    [SerializeField] private Deck _deck;
    private void Start()
    {
        List<Card> copyDeck = new List<Card>(_deck.DeckOfCard);
        for (int numberOfCard = 0; numberOfCard < _numberOfCardsToDraw; numberOfCard++)
        {
            int cardToPick = Random.Range(0, copyDeck.Count);
            _handOfCards.Add(copyDeck[cardToPick]);
            copyDeck.RemoveAt(cardToPick);
        }
    }
}
