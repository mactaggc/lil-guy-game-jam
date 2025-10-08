using Godot;
using System;

public partial class Main : Node2D
{
    Player player;
    Label candycounter;

    public override void _Ready()
    {
        player = GetNode("Player") as Player;
        candycounter = GetNode("CanvasLayer").GetNode<Label>("Candies");
    }
    public override void _Process(double delta)
    {
        candycounter.Text = "Candies Collected: " + player.candyC;
    }

}
