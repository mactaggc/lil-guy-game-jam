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

        //Getting input strength, and moving our player by applying speed.
        velocity.X = Input.GetAxis("ui_left","ui_right") * player.SPEED; // SPEED == 300


        if (Input.IsActionJustPressed("ui_up") && player.IsOnFloor())
        {
            velocity.Y += player.JUMP_VELOCITY; // -400
        }

        velocity.Y = Mathf.Clamp(velocity.Y, player.JUMP_VELOCITY, -player.JUMP_VELOCITY*2); // Limiting the player's verticle movement i.e. can fall twice as fast as he can jump.
        velocity.Y += 800 * delta;
        player.Velocity = velocity;
        player.MoveAndSlide();
    }
}
