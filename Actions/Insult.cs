namespace GameJam2023MarsYeah.Actions;

public class Insult : Action{

	public Insult() : base("Insult human leaders", "The current SpaceX CEO is balding rapidly. Make sure the world knows.") {}

	public override int GetPopularityEffect(GameState state) => 10;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => !state.IsHumanTurn;

	public override float GetProbability(GameState state) => 1;
}