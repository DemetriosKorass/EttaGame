using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    // Cards neighbors on grid
    public Card TopCard;
    public Card RightCard;
    public Card LeftCard;
    public Card DownCard;

    // Card prefab
    public GameObject Body;

    // Basic properties
    protected int Colour    = 1;
    protected int Form      = 1;
    protected int Number    = 1;
    protected int Type      = 1; // 1 - simple card, 2 - joker card

    protected Dictionary<int, string> Colour_display = new Dictionary<int, string>
    {
        {1, "Blue"},
        {2, "Green"},
        {3, "Red"},
        {4, "Yellow"}
    };
    protected Dictionary<int, string> Form_display = new Dictionary<int, string>
    {
        {1, "Rectangle"},
        {2, "Triangle"},
        {3, "Circle"},
        {4, "Cross"}
    };

    void Start()
    {
        TextUpdate();
    }

    // Set Color, Form and Number of Card
    public void SetProperties(int c, int f, int n)
    {
        Colour   = c;
        Form    = f;
        Number  = n;
        TextUpdate();
    }
    // Set card as joker card
    public void SetJoker()
    {
        Type = 2;
    }
    // Set card as simple card
    public void SetSimple()
    {
        Type = 1;
    }
    // Set prefab for card
    public void SetBody(GameObject new_body)
    {
        Body = new_body;
    }
    // Print debug information (card properties as numbers)
    public void PrintDebug()
    {
        string string_type = "";
        if (Type == 2)
            string_type = "Joker ";
        Debug.Log(string_type + Colour.ToString() + " " + Form.ToString() + " " + Number.ToString());
    }
    // Print normal information about card
    public void Print()
    {
        string string_type = "";
        if (Type == 2)
            string_type = "Joker ";
        Debug.Log(string_type + Colour_display[Colour] + " " + Form_display[Form] + " " + Number.ToString());
    }
    // Update text on prefab body
    // TODO:
    public void TextUpdate()
    {
        //Body.GetComponent<Text>().text = Colour_display[Colour] + "\n" + Form_display[Form] + "\n" + Number.ToString() + "\n";
    }
    
}
