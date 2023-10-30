namespace GameJam2023MarsYeah.Actions;

// ReSharper disable once InconsistentNaming
public class UFO : Action
{
	private const string Title = "Deploy UFO Squadron";
	private const string Flavour = "Deploy a squadron of UFOs to abduct SpaceY exectutives";

	public UFO() : base(Title, Flavour)
	{
	}

	public override int GetPopularityEffect(GameState state) => -100;

	public override int GetDamage(GameState state) => 100;

	public override bool CanBeUsed(GameState state) => !state.IsHumanTurn && state.Opinion >= 100;

	public override int GetProbability(GameState state) => 100;
}