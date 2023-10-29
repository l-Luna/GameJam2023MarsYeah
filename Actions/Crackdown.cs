using GameJam2023MarsYeah.Statuses;

namespace GameJam2023MarsYeah.Actions;

public class Crackdown : Action
{
	public Crackdown() : base("Protest crackdown", "Clearly, the general population doesn't understand what we're trying to do here. Lobby the world's governments to stop the protests, by any means necessary."){}

	public override int GetPopularityEffect(GameState state) => -30;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => state.IsHumanTurn && state.StatusActive(typeof(Protesting));

	public override float GetProbability(GameState state) => 1;

	public override Status GetStatusEffect() => null;
	public override bool StatusEnded() => true;
}