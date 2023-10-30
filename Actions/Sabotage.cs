using System;
using System.Collections.Generic;
using System.Linq;

namespace GameJam2023MarsYeah.Actions;

public class Sabotage : Action
{
	private const string Title = "Sabotage human colony";
	private const string Flavour = "Sabotage the human colony and destroy their settlements";

	private static readonly List<Type> ActionsRemovalSequence = new()
	{
		typeof(PlasmaReactor),
		typeof(Factories),
		typeof(Colony)
	};

	public Sabotage() : base(Title, Flavour)
	{
	}

	public override int GetPopularityEffect(GameState state) => -20;

	public override int GetDamage(GameState state) => !state.ActionUsed(typeof(Factories)) ? 20 : 10;

	public override bool CanBeUsed(GameState state) => !state.IsHumanTurn &&
	                                                   state.Opinion >= -75  &&
	                                                   state.ActionUsed(typeof(Colony));

	public override int GetProbability(GameState state) => 20;

	public override Type RemoveOtherAction(GameState state) => ActionsRemovalSequence.FirstOrDefault(state.ActionUsed, null);
}