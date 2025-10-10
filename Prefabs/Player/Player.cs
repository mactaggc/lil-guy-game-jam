using Godot;
using System;
using System.Runtime.Serialization;

public partial class Player : CharacterBody2D
{
    [Export] public float speed;
    [Export] public float jump_velocity;
    [Export] public int health;
    [Export] public int candyC;
    public bool isBiting;
    public pInput input;
    pAnimationController anim;
    public HitManager hit;
    public Camera2D camera;
    public override void _Ready()
    {
        AddToGroup("player");
        input = GetNode<pInput>("Input");
        anim = GetNode<pAnimationController>("AnimatedSprite2D");
        hit = GetNode("HitManager") as HitManager;
        camera = GetNode("Camera2D") as Camera2D;
    }

    public void AcceptSave(int h, int c, Vector2 pos)
    {
        health = h;
        candyC = c;
        Position = pos;
    }

    public override void _PhysicsProcess(double delta)
    {
        anim.Animate();
        input.Eat();
        input.Move((float)delta);
    }
}
