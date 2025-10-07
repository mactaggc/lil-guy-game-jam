using Godot;
using System;

public partial class Main : Node2D
{
    CharacterBody2D player;

    public override void _Ready()
    {
        player = GetNode<CharacterBody2D>("Player");
    }
    public override void _Process(double delta)
    {

    }

}
