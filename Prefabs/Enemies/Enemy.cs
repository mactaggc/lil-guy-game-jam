using Godot;
using System;

public partial class Enemy : Area2D
{
    //Base class and functions for enemy type scenes.
    [Export] public int health;
    [Export] public float speed;
    [Export] public float jumpHeight;
    public Vector2 pos;
    public override void _Ready()
    {
        AddToGroup("enemy");
    }

    public void Move(Vector2 pos, float delta)
    {
        Position = Position.MoveToward(pos, speed * delta);
    }

    public override void _Process(double delta)
    {
        Move(pos, (float)delta);
    }

    

}
