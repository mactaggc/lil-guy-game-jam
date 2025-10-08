using Godot;
using System;
using System.Runtime.Serialization;

public partial class Player : CharacterBody2D
{
    [Export] public float SPEED = 250;
    [Export] public float JUMP_VELOCITY = -300;
    [Export] public int health;
    [Export] public int candyC;
    public bool isBiting;
    pInput input;
    pAnimationController anim;
    public override void _Ready()
    {
        AddToGroup("player");
        input = GetNode<pInput>("Input");
        anim = GetNode<pAnimationController>("AnimatedSprite2D");
    }

    public override void _PhysicsProcess(double delta)
    {
        anim.Animate();
        input.Eat();
        input.Move((float)delta);
    }

}
