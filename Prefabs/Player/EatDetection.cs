using Godot;
using System;

public partial class EatDetection : Node
{
    public bool eatBpressed;
    Area2D hd1;
    Area2D hd2;
    public override void _Ready()
    {
        hd1 = GetParent().GetNode<Area2D>("HitDetector");
        hd2 = GetParent().GetNode<Area2D>("HitDetector2");
    }


    public void OnBodyEnter(PhysicsBody2D body)
    {
        if (eatBpressed)
        {
            body.MoveLocalX(200f);
            GD.Print("Works!");
        }
    }

    public void OnBodyEnter2(PhysicsBody2D body)
    {
        if (eatBpressed)
        {
            body.MoveLocalX(200f);
            GD.Print("Works!");
        }
    }
}
