namespace GameJam2023MarsYeah.Actions;

public class PlasmaReactor : Action
{
	private const string Title = "Set up Plasma Reactor";
	private const string Flavour = "Build a plasma reactor to convert carbon dioxide to oxygen";

	public PlasmaReactor() : base(Title, Flavour)
	{
	}

	public override int GetPopularityEffect(GameState state) => state.ActionUsed(typeof(Education)) ? -10 : 20;

	public override int GetDamage(GameState state) => 20;

	public override bool CanBeUsed(GameState state) => state.IsHumanTurn &&
	                                                   !state.ActionUsed(typeof(PlasmaReactor)) &&
	                                                   state.ActionUsed(typeof(Factories));

	public override int GetProbability(GameState state) => 1;
}