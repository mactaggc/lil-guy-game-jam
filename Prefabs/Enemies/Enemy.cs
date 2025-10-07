using Godot;
using System;

public partial class Enemy : Area2D
{
    //Base class and functions for enemy type scenes.
    [Export] public int health;
    [Export] public float speed;
    [Export] public float jumpHeight;
    public Vector2 pos;
    public bool inView;
    public override void _Ready()
    {
        AddToGroup("enemy");
        inView = false;
    }

    public void Move(Vector2 pos, bool a)
    { 
        Position = Position.MoveToward(pos, speed * (float)GetProcessDeltaTime());
    }

    public override void _Process(double delta)
    {
        Move(pos, inView);
    }


}
