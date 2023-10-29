using System;
using System.Collections.Generic;
using System.Linq;

namespace GameJam2023MarsYeah.Actions;

public static class ActionManager {

	public static readonly List<Action> All = new List<Action>(){
		new InsultOpponent()
	};

	public static List<Action> GetValidActions(GameState state, int amount){
		// all the actions where CanTrue returns true
		List<Action> valid = All.Where(x => x.CanBeUsed(state)).ToList();
		// if we don't have enough actions, then we have a problem
		if(amount > valid.Count)
			throw new Exception("we don't have that many actions!");
		// TODO: not technically correct but "good enough"
		return valid
			.OrderBy(x => state.Rng.Randf() * x.GetProbability(state))
			.Take(amount)
			.ToList();
	}
}