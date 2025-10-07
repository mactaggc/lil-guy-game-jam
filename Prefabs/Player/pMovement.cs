using Godot;
using System;

public partial class pMovement : Node
{
    Player player;
    public override void _Ready()
    {
        player = GetParent() as Player;
    }

    public void Move(float delta)
    {
        Vector2 velocity = player.Velocity;

        if (Input.IsActionPressed("ui_right"))
        {
            velocity.X = player.SPEED; // 300
        }
        else if (Input.IsActionPressed("ui_left"))
        {
            velocity.X = -player.SPEED;
        }
        else
        {
            velocity.X = 0;
        }

        if (Input.IsActionJustPressed("ui_up") && player.IsOnFloor())
        {
            velocity.Y = -player.JUMP_VELOCITY; // -400
        }

        velocity.Y = Math.Clamp(velocity.Y, -player.JUMP_VELOCITY, 1200);
        velocity.Y += 1200 * delta;
        player.Velocity = velocity;
        player.MoveAndSlide();
    }
}
