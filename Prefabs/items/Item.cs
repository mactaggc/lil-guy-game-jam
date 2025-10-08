using Godot;
using System;
using System.Runtime.Intrinsics.X86;

public partial class Item : Area2D
{
    //Base class for all item scenes.
    [Export] public int healthAdd;
    [Export] public string itemDescription;
    [Export] public int eMultiplier;

    //When Making new item, add all dependencies to scene that are listed below.
    Label textLabel;
    public override void _Ready()
    {
        AddToGroup("candy");
        textLabel = GetNode<Label>("Label");
        textLabel.Text = itemDescription;
        textLabel.Hide();
    }

    public void statusEffect(Player p)
    {
        if(IsQueuedForDeletion())
            p.health += healthAdd;
    }

    public void showDescription()
    {
        textLabel.Visible = !textLabel.Visible;
    }
}
