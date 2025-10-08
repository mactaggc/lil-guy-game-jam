using Godot;
using System;
using System.Buffers.Binary;

public partial class pAnimationController : AnimatedSprite2D
{
    Player p;

    public override void _Ready()
    {
        p = GetParent() as Player;
    }

    public void Animate()
    {
        if (p.Velocity.X > 0)
            FlipH = false;
        else if (p.Velocity.X < 0)
            FlipH = true;
        if (p.Velocity == Vector2.Zero)
            Play("Idle");
        else if (p.Velocity.X != 0)
            Play("roll");
        if (p.isBiting)
            Play("Bite");
    }

    public void OnAnimationFinish()
    {
        if (p.isBiting)
            p.isBiting = false;
    }
}
