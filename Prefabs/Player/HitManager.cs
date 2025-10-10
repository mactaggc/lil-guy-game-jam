using Godot;
using System;

public partial class HitManager : Node
{
    PackedScene _deathScreen = ResourceLoader.Load<PackedScene>("res://Prefabs/Menus/DeathScreen.tscn");
    Player p;
    Main main;

    public override void _Ready()
    {
        p = GetParent() as Player;
        main = GetParent().GetParent() as Main;
    }

    private Vector2 Knockback(Enemy enemy)
    {
        return new Vector2(2 * p.speed * (p.GlobalPosition.X - enemy.GlobalPosition.X), p.input.velocity.Y += -150);
    }

    private void Death()
    {
        if(!GetTree().HasGroup("death"))
        {
            var r = _deathScreen.Instantiate();
            p.camera.Enabled = false;
            main.AddChild(r);
        }
        
    }
    
    public void GetHit(int damage, Enemy enemy)
    {
        p.health -= damage;
        p.Velocity = Knockback(enemy);
        if (p.health <= 0)
        {
            Death();
        }
    }
}
