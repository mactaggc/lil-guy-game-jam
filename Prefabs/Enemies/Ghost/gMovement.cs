using Godot;
using System;
using System.Runtime.InteropServices;

public partial class gMovement : Node
{

    Ghost ghost;    
    public override void _Ready()
    {
        ghost = GetParent() as Ghost;
    }

    public void OnPlayerEnter(PhysicsBody2D body)
    {
        if (body.IsInGroup("player"))
        {
            ghost.posA = body.Position;
            GD.Print("This Works!!");
        }
        else
        {
            ghost.posA = ghost.Position;
        }
    }
}
