namespace GameJam2023MarsYeah.Actions;

public class Colony : Action
{
	private const string Title = "Set up a Colony";
	private const string Flavour = "Build a colony to house the humans";

	public Colony() : base(Title, Flavour)
	{
	}

	public override int GetPopularityEffect(GameState state) => state.Opinion != 0 ? 5 : 0;

	public override int GetDamage(GameState state) => 5;

	public override bool CanBeUsed(GameState state) => state.IsHumanTurn && !state.ActionUsed(GetType());

	public override int GetProbability(GameState state) => 100;
}