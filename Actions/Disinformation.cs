namespace GameJam2023MarsYeah.Actions;

public class Disinformation : Action{
	public Disinformation() : base("Disinformation Campaign", "Spread misinformation and harm your opponents reputation"){}

	public override int GetPopularityEffect(GameState state) => 30;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => state.IsHumanTurn && state.Opinion < 0;

	public override int GetProbability(GameState state) => 1;
}