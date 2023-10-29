namespace GameJam2023MarsYeah.Actions;

public class InsultOpponent : Action{

	public InsultOpponent() : base("Insult Opponent") {}

	public override int GetPopularityEffect(GameState state) => 10;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => true;

	public override float GetProbability(GameState state) => 1;
}