using Godot;
using System;

public partial class TestObject : Area2D
{
	public override void _Ready()
	{
		AddToGroup("enemy");
	}

}
