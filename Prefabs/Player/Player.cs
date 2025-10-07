using Godot;
using System;
using System.Runtime.Serialization;

public partial class Player : CharacterBody2D
{
    [Export] public float SPEED = 250;
    [Export] public float JUMP_VELOCITY = -300;
    pInput input;
    pAnimationController anim;
    public override void _Ready()
    {
        AddToGroup("player");
        input = GetNode<pInput>("Input");
        anim = GetNode<pAnimationController>("AnimatedSprite2D");
    }

    public override void _Process(double delta)
    {
        input.Move((float)delta);
        input.Eat();
        anim.Animate();
    }

}
