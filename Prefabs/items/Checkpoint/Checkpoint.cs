using Godot;
using System;
using System.IO;
using System.Transactions;

public partial class Checkpoint : Area2D
{
    Array data;

    private void SavePlayerData(Player p)
    {
        using var saveData = Godot.FileAccess.Open("res://savedata.dat", Godot.FileAccess.ModeFlags.Write);
        saveData.Seek(0);
        saveData.StoreLine(p.health.ToString());
        saveData.StoreLine(p.candyC.ToString());
        GD.Print("Data Saved!");
    }
    
    public void OnPlayerEnter(Node2D body)
    {
        if(body.IsInGroup("player"))
        {
            SavePlayerData(body as Player);
        }
    }
    
}
