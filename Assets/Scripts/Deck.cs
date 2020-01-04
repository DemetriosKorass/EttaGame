using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField]
    private GameObject card_body;
    private List<Card> CardDeck = new List<Card>();
    private List<GameObject> Cards = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        CreateDeck();
        Print();
        for (int i = 0; i < 2; i++) ShuffleDeck();
        Print();
        CreateVisualDeck();
    }
    private void CreateDeck()
    {
        for (int color = 1; color <= 4; color++)
            for (int form = 1; form <= 4; form++)
                for (int number = 1; number <= 4; number++)
                {
                    Card temp_card = new Card();
                    temp_card.SetBody(card_body);
                    temp_card.SetProperties(color, form, number);
                    CardDeck.Add(temp_card);
                }
        Card joker = new Card();
        joker.SetJoker();
        joker.SetBody(card_body);
        CardDeck.Add(joker);
        CardDeck.Add(joker);
    }

    private void CreateVisualDeck()
    {
        int i = 0;
        float step = 1f / 66f;
        Debug.Log(CardDeck.Count);
        foreach (Card c in CardDeck)
        {
            Cards.Add(Instantiate(c.Body, new Vector3(1,1+step*i,1), Quaternion.identity));
            i += 1;
        }
    }
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
