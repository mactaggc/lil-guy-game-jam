using Godot;
using System;

public partial class pInput : Node
{
    Player player;
    EatDetection eatDetection;
    public Vector2 velocity;
    
    public override void _Ready()
    {
        player = GetParent() as Player;
        eatDetection = GetParent().GetNode<EatDetection>("EatDetection");
    }

    public void Move(float delta)
    {
        velocity = player.Velocity;

        //Getting input strength, and moving our player by applying speed.
        velocity.X += Input.GetAxis("ui_left", "ui_right") * player.speed; // speed == 300
        

        if (Input.IsActionJustPressed("ui_up") && player.IsOnFloor())
        {
            velocity.Y += player.jump_velocity; // -400
        }

        velocity.X = Mathf.MoveToward(velocity.X, 0, 35);
        velocity.X = Math.Clamp(velocity.X, -player.speed, player.speed);
        velocity.Y = Mathf.Clamp(velocity.Y, player.jump_velocity, -player.jump_velocity * 2); // Limiting the player's verticle movement i.e. can fall twice as fast as he can jump.
        velocity.Y += 800 * delta;
        player.Velocity = velocity;
        player.MoveAndSlide();
    }

    public void Eat()
    {
        if (Input.IsActionJustPressed("ui_accept"))
        {
            // Enabling EatDetections Area2D to detect Areas within its collision box.
            eatDetection.hd1.Monitoring = true;
            eatDetection.hd2.Monitoring = true;
            player.isBiting = true;
        }
        else
        {
            eatDetection.hd1.Monitoring = false;
            eatDetection.hd2.Monitoring = false;
        }
    }
}
