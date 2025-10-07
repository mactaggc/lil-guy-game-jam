using Godot;
using System;

public partial class Player : CharacterBody2D
{
    public const int SPEED = 300;
    public const int JUMP_VELOCITY = -400;
    public override void _Ready()
    {
        AddToGroup("player");
    }
}
