using System;

namespace GameJam2023MarsYeah.Actions;

public class Crackdown : Action
{
	private const string Title = "Protest crackdown";
	private const string Flavour = "Clearly, the general population doesn't understand what we're trying to do here. Lobby the world's governments to stop the protests, by any means necessary";
	public override bool IsExclusive => true;

	public Crackdown() : base(Title, Flavour){}

	public override int GetPopularityEffect(GameState state) => -30;

	public override int GetDamage(GameState state) => 10;

	public override bool CanBeUsed(GameState state) => state.IsHumanTurn && state.ActionUsed(typeof(Protest));

	public override int GetProbability(GameState state) => 1;

	public override Type RemoveOtherAction(GameState state) => typeof(Protest);
}