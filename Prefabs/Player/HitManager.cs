using Godot;
using System;

public partial class HitManager : Node
{
    Player p;


    public override void _Ready()
    {
        p = GetParent() as Player;
    }

    public void GetHit(int damage, Enemy enemy)
    {
        p.health -= damage;
        p.Velocity = new Vector2(10*(p.GlobalPosition.X - enemy.GlobalPosition.X),p.input.velocity.Y += -100);
        if (p.health <= 0)
        {
            p.QueueFree();
        }
    }
}
