using Godot;
using System;

public partial class MainMenu : Control
{
    PackedScene test = ResourceLoader.Load<PackedScene>("res://main.tscn");

    public void OnStartPress()
    {
        GetTree().ChangeSceneToPacked(test);
    }
}
