using Godot;
using System;

public partial class EatDetection : Node
{
    public bool eatBpressed;
    public Area2D hd1;
    public Area2D hd2;
    Player p;
    public override void _Ready()
    {
        p = GetParent() as Player;
        hd1 = GetParent().GetNode<Area2D>("HitDetector");
        hd2 = GetParent().GetNode<Area2D>("HitDetector2");

        hd1.Monitoring = false;
        hd2.Monitoring = false;
    }


    public void OnBodyEnter(Item body)
    {
        if (body.IsInGroup("candy"))
        {
            body.QueueFree();
            body.statusEffect(p);
            p.candyC += 1;
        }
    }

    public void OnBodyEnter2(Area2D body)
    {
        if (body.IsInGroup("candy"))
        {
            body.QueueFree();
            p.candyC += 1;     
        }
    }
}
