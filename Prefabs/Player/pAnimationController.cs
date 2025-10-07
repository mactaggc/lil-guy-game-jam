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
        if (p.Velocity == Vector2.Zero)
        {
            Animation = "Idle";
        }
        else if (p.Velocity.X != 0)
        {
            Animation = "Bite";
            if (p.Velocity.X > 0)
                FlipH = false;
            else if (p.Velocity.X < 0)
                FlipH = true;
        }
        
        
    }
}
