﻿namespace GameJam2023MarsYeah.Actions;

public class InsultOpponent : Action{
	private const string ActionTextFileName = "res://Actions/InsultOpponent.txt";

	public InsultOpponent() : base(ActionTextFileName) {}

	public override void OnSelect(GameState state){}

	public override int GetPopularityEffect(GameState state) => 10;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => true;

	public override float GetProbability(GameState state) => 1;
}