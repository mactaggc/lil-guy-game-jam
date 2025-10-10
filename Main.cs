using Godot;
using System;

public partial class Main : Node2D
{
    Player player;
    Label candycounter;
    Label healthcounter;

    public override void _Ready()
    {
        player = GetNode("Player") as Player;
        candycounter = GetNode("GUI").GetNode<Label>("Candies");
        healthcounter = GetNode("GUI").GetNode<Label>("Health");
        AddToGroup("root");
    }
    
    
    public override void _Process(double delta)
    {
        candycounter.Text = "Candies Collected: " + player.candyC;
        healthcounter.Text = "Health: " + player.health;
    }

}
