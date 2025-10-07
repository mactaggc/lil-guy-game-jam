using Godot;
using System;

public partial class Ghost : Area2D
{
    public override void _Ready()
    {
        AddToGroup("enemies");
    }

    public void OnPlayerEnter(PhysicsBody2D body)
    {
        if (body.IsInGroup("player"))
        {
            GD.Print("Works");
        }
    }
}
