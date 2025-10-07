using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export] public float SPEED = 300;
    [Export] public float JUMP_VELOCITY = -400;
    pMovement movement;
    public override void _Ready()
    {
        AddToGroup("player");
        movement = GetNode<pMovement>("Movement");
    }

    public override void _Process(double delta)
    {
        movement.Move((float)delta);
    }

}
