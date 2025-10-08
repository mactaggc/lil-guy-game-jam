using Godot;
using System;

public partial class Candy : Item
{
    public void OnMouseEnter()
    {
        showDescription();
    }
    public void OnMouseExit()
    {
        showDescription();
    }
}
