using Godot;
using System;

public partial class pMovement : Node
{
    CharacterBody2D player;
    public override void _Ready()
    {
        player = GetNode<CharacterBody2D>("../Player");
    }
}
