using Godot;
using System;
using System.IO;
using System.Transactions;

public partial class Checkpoint : Area2D
{
    private void SavePlayerData(Player p)
    {
        using var saveData = Godot.FileAccess.Open("res://savedata.dat", Godot.FileAccess.ModeFlags.Write);
        saveData.Seek(0);
        saveData.StoreLine(p.health.ToString());
        saveData.StoreLine(p.candyC.ToString());
        saveData.StoreVar(Position);
        GD.Print("Data Saved!");

        SetCollisionLayerValue(1, false);
        SetCollisionMaskValue(1, false);
    }
    
    public void OnPlayerEnter(Node2D body)
    {
        if(body.IsInGroup("player"))
        {
            SavePlayerData(body as Player);
        }
    }
    
}
