using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{

    // POLYMORPHISM
    protected override void displayName()
    {
        TextBox = "Cylinder";
    }

    private void OnMouseDown()
    {
        // ABSTRACTION
        displayName();
    }
}
