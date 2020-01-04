using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField]
    private GameObject card_body;   // Card prefab
    private List<Card> CardDeck = new List<Card>();             // List of abstact cards
    private List<GameObject> Cards = new List<GameObject>();    // List of physics cards
    // Start is called before the first frame update
    void Start()
    {
        CreateDeck();
        //Print();
        for (int i = 0; i < 2; i++) ShuffleDeck();
        //Print();
        CreateVisualDeck();
    }
    // Creating deck of cards
    private void CreateDeck()
    {
        // Add simple cards
        for (int color = 1; color <= 4; color++)
            for (int form = 1; form <= 4; form++)
                for (int number = 1; number <= 4; number++)
                {
                    Card temp_card = new Card();
                    temp_card.SetBody(card_body);
                    temp_card.SetProperties(color, form, number);
                    CardDeck.Add(temp_card);
                }
        // Add jokers
        Card joker = new Card();
        joker.SetJoker();
        joker.SetBody(card_body);
        CardDeck.Add(joker);
        CardDeck.Add(joker);
    }
    // Creating visuality of deck
    private void CreateVisualDeck()
    {
        GameObject temp_card;
        int i = CardDeck.Count;
        float step = 1f / 66f;
        foreach (Card c in CardDeck)
        {
            temp_card = (Instantiate(c.Body, new Vector3(1,1+step*i,1), Quaternion.Euler(0,0,180)));
            temp_card.name = "Card" + (CardDeck.Count - i + 1).ToString();
            Cards.Add(temp_card);
            i -= 1;
        }
    }
    // Shuffle deck
    private void ShuffleDeck()
    {
        for (int index = 0; index < CardDeck.Count - 3; index++)
        {
            int random_card_index = Random.Range(index + 1, CardDeck.Count);
            Card temp_card = CardDeck[random_card_index];
            CardDeck[random_card_index] = CardDeck[index];
            CardDeck[index] = temp_card;
        }
    }
    // Get top card from deck
    public Card GetCard()
    {
        Card temp_card = null;
        if (CardDeck.Count != 0)
        {
            temp_card = CardDeck[0];
            CardDeck.RemoveAt(0); 
        }
        return temp_card;
    }
    // Print all card in  deck
    public void Print()
    {
        foreach(Card deck_card in CardDeck)
        {
            deck_card.Print();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
