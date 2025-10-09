using Godot;
using System;

public partial class Main : Node2D
{
    Player player;
    Label candycounter;
    Label healthcounter;
    Checkpoint checkpoint;

    public override void _Ready()
    {
        player = GetNode("Player") as Player;
        checkpoint = GetNode("Checkpoint") as Checkpoint;
        candycounter = GetNode("CanvasLayer").GetNode<Label>("Candies");
        healthcounter = GetNode("CanvasLayer").GetNode<Label>("Health");
        LoadSave();
    }
    
    public void LoadSave()
    {
        var saveData = Godot.FileAccess.Open("res://savedata.dat", Godot.FileAccess.ModeFlags.Read);
        saveData.Seek(0);
        player.AcceptSave(saveData.GetLine().ToInt(),(int)saveData.GetLine().ToInt());
    }
    public override void _Process(double delta)
    {
        candycounter.Text = "Candies Collected: " + player.candyC;
        healthcounter.Text = "Health: " + player.health;
    }

}
