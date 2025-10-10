using Godot;
using System;

public partial class MainMenu : Control
{
    PackedScene _test = ResourceLoader.Load<PackedScene>("res://main.tscn");

    public void OnRestartPressed()
    {
        
    }
    public void OnCheckpointPressed()
    {
        GetTree().ChangeSceneToPacked(_test);
    }
}
