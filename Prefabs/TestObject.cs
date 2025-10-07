using Godot;
using System;

public partial class TestObject : RigidBody2D
{
	public override void _Ready()
	{
		AddToGroup("enemy");
	}

}
