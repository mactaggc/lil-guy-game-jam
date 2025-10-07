using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export] public float SPEED = 250;
    [Export] public float JUMP_VELOCITY = -300;
    pMovement movement;
    pAnimationController anim;
    public override void _Ready()
    {
        AddToGroup("player");
        movement = GetNode<pMovement>("Movement");
        anim = GetNode<pAnimationController>("AnimatedSprite2D");
    }

    public override void _Process(double delta)
    {
        movement.Move((float)delta);
        anim.Animate();
    }

}
