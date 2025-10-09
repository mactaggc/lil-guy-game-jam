using Godot;
using System;

public partial class DeathScreen : Control
{
    PackedScene _main = GD.Load<PackedScene>("res://main.tscn");
    public void OnRestartPressed()
    {
        GetTree().ChangeSceneToPacked(_main);
    }
}
