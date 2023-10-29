﻿using Godot;

namespace GameJam2023MarsYeah;

public class GameState : Node{

	public int HumanHealth, MartianHealth, Opinion;

	public bool IsHumanTurn;
	
	public override void _Ready(){
		base._Ready();
		HumanHealth = MartianHealth = 100;
		Opinion = -100;
		IsHumanTurn = true;
	}
}