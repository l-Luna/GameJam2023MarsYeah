namespace GameJam2023MarsYeah.Actions;

public class Disinformation : Action{
	public Disinformation() : base("Disinformation Campaign"){}

	public override int GetPopularityEffect(GameState state) => 30;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => state.IsHumanTurn && state.Opinion < 0;

	public override float GetProbability(GameState state) => 1;
}