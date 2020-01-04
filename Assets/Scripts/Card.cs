using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{

    // Basic properties
    private int Color   = 1;
    private int Form    = 1;
    private int Number  = 1;

    private int Type = 1;

    private Dictionary<int, string> Color_display = new Dictionary<int, string>
    {
        {1, "Blue"},
        {2, "Green"},
        {3, "Red"},
        {4, "Yellow"}
    };
    private Dictionary<int, string> Form_display = new Dictionary<int, string>
    {
        {1, "Rectangle"},
        {2, "Triangle"},
        {3, "Circle"},
        {4, "Cross"}
    };
    

    // Set Color, Form and Number of Card
    public void SetProperties(int c, int f, int n)
    {
        Color   = c;
        Form    = f;
        Number  = n;
    }

    public void SetJoker()
    {
        Type = 2;
    }

    public void SetSimple()
    {
        Type = 1;
    }
    public void PrintDebug()
    {
        string string_type = "";
        if (Type == 2)
            string_type = "Joker ";
        Debug.Log(string_type + Color.ToString() + " " + Form.ToString() + " " + Number.ToString());
    }
    public void Print()
    {
        string string_type = "";
        if (Type == 2)
            string_type = "Joker ";
        Debug.Log(string_type + Color_display[Color] + " " + Form_display[Form] + " " + Number.ToString());
    }
}
