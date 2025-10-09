using Godot;
using System;
using System.Runtime.Serialization;

public partial class Player : CharacterBody2D
{
    [Export] public float speed = 250;
    [Export] public float jump_velocity = -300;
    [Export] public int health;
    [Export] public int candyC;
    public bool isBiting;
    public pInput input;
    pAnimationController anim;
    public HitManager hit;
    public override void _Ready()
    {
        AddToGroup("player");
        input = GetNode<pInput>("Input");
        anim = GetNode<pAnimationController>("AnimatedSprite2D");
        hit = GetNode("HitManager") as HitManager;
    }

    public override void _PhysicsProcess(double delta)
    {
        anim.Animate();
        input.Eat();
        input.Move((float)delta);
    }

}
