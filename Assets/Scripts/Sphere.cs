using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{

    // POLYMORPHISM
    protected override void displayName()
    {
        TextBox = "Sphere";
    }

    private void OnMouseDown()
    {
        // ABSTRACTION
        displayName();
    }
}
