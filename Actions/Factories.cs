namespace GameJam2023MarsYeah.Actions;

public class Factories : Action{
	private const string Title = "Build factories";

	private const string Flavour =
		"Mars is REALLY cold. Build a few thousand factories to churn out greenhouse gases (proven effective in raising global temperatures)";

	public Factories() : base(Title, Flavour) {}

	public override int GetPopularityEffect(GameState state) => state.ActionUsed(typeof(Education)) ? -10 : 20;

	public override int GetDamage(GameState state) => state.ActionUsed(typeof(Education)) ? 10 : 15;

	public override bool CanBeUsed(GameState state) => state.IsHumanTurn && state.ActionUsed(typeof(Colony));

	public override int GetProbability(GameState state) => 1;
}