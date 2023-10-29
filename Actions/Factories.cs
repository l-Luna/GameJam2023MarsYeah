using GameJam2023MarsYeah.Statuses;

namespace GameJam2023MarsYeah.Actions;

public class Factories : Action{

	public Factories() : base("Build factories", "Mars is fucking cold. Build a few thousand factories to churn out greenhouse gases (proven effective in raising global temperatures).") {}

	public override int GetPopularityEffect(GameState state) => 0;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => state.IsHumanTurn;

	public override float GetProbability(GameState state) => 1;
	public override Status GetStatusEffect() => null;
	public override bool StatusEnded() => true;
}