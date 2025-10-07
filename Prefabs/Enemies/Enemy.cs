using Godot;
using System;

public partial class Enemy : Area2D
{
    //Base class and functions for enemy type scenes.
    [Export] public int health;
    [Export] public float speed;
    [Export] public float jumpHeight;

    public void OnPlayerEnter(PhysicsBody2D body)
    {
        if (body.IsInGroup("player"))
        {
            GD.Print("Works");
        }
    }
    public override void _Ready()
    {
        AddToGroup("enemy");
    }

    public void Move()
    {

    }
}
