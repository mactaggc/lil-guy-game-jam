using Godot;
using System;

public partial class Rat : Enemy
{
    public void OnPlayerEnter(Node2D body)
    {
        if (body.IsInGroup("player"))
        {
            HitPlayer(body as Player);
        }
    }
}
