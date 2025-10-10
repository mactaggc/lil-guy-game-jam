using Godot;
using System;

public partial class DeathScreen : Control
{
    PackedScene _main = GD.Load<PackedScene>("res://main.tscn");
    bool res;
    Player player;

    public override void _Ready()
    {
        player = GetTree().GetFirstNodeInGroup("player") as Player;
        AddToGroup("death");
    }

    public void LoadSave()
    {
        var saveData = Godot.FileAccess.Open("res://savedata.dat", Godot.FileAccess.ModeFlags.Read);
        saveData.Seek(0);
        player.AcceptSave(saveData.GetLine().ToInt(), (int)saveData.GetLine().ToInt(), (Vector2)saveData.GetVar());
        player.camera.Enabled = true;
    }
    public void OnCheckpointPressed()
    {
        LoadSave();
        QueueFree();
    }

    public void OnRestartPressed()
    {
        GetTree().ChangeSceneToPacked(_main);
    }
}
