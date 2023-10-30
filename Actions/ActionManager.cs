using System;
using System.Collections.Generic;
using System.Linq;

namespace GameJam2023MarsYeah.Actions;

public static class ActionManager
{
	private static readonly List<Action> All = new()
	{
		new Colony(),
		new Crackdown(),
		new Disinformation(),
		new Education(),
		new Elon(),
		new Factories(),
		new InsultHumans(),
		new InsultMartians(),
		new Memes(),
		new PlasmaReactor(),
		new Protest(),
		new Sabotage(),
		new UFO()
	};

	public static List<Action> GetValidActions(GameState state)
	{
		bool hasExclusive = false;
		List<Action> valid = All
			.Where(x => x.CanBeUsed(state))
			.Select(x =>
			{
				if (x.IsExclusive)
					hasExclusive = true;
				return x;
			})
			.ToList();

		int amount = Math.Min(3, valid.Count);
		return valid
			.Where(x => !hasExclusive || x.IsExclusive)
			.OrderByDescending(x => state.Rng.Randf() * x.GetProbability(state))
			.Take(amount)
			.ToList();
	}
}