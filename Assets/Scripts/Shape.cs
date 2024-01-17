using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private TextMeshProUGUI textBox;

    // ENCAPSULATION
    public string TextBox
    {
        get { return textBox.text;  }
        set
        {
            if (value.Length < 10)
            {
                textBox = GameObject.Find("ShapeNameText").GetComponent<TextMeshProUGUI>();
                textBox.text = value;
            } else
            {
                Debug.Log("Too long!");
            }
        }
    }

    protected virtual void displayName()
    {
        textBox.text = "Shape";
    }
}
