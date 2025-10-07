using Godot;
using System;

public partial class Ghost : Enemy
{ 
    public override void _Ready()
    {
        health = 20;
    }
}
