using Godot;
using System;
using System.Security.Cryptography;

public partial class Enemy : Area2D
{
    //Base class and functions for enemy type scenes.
    [Export] public int health;
    [Export] public float speed;
    [Export] public float jumpHeight;
    [Export] public bool moveType; // Determines what kind of movement the enemy uses. Either Move towards Player or back and forth movement.
    [Export] public Vector2 posA; // Used for both player detection or moving between two points.
    [Export] public Vector2 posB; // Second point for MoveBAF
    private bool dir; // Used for BAF to determine what point to move to.
    AnimatedSprite2D sprite;
    public override void _Ready()
    {
        AddToGroup("enemy");
    }

    public void Animate()
    {

    }
    public void Move(Vector2 pos, float delta)
    {
        Position = Position.MoveToward(pos, speed * delta);
    }

    public void MoveBAF(Vector2 pos1, Vector2 pos2, float delta)
    {
        if (dir)
        {
            if (Position != pos2)
                Position = Position.MoveToward(pos2, speed * delta);
        }

        if (!dir)
        {
            if (Position != pos1)
                Position = Position.MoveToward(pos1, speed * delta);
        }
        if (Position.IsEqualApprox(posA))
            dir = true;
        if (Position.IsEqualApprox(posB))
            dir = false;
            
    }

    public override void _Process(double delta)
    {
        if (!moveType)
            Move(posA, (float)delta);
        else
            MoveBAF(posA, posB, (float)delta);
    }
}