namespace GameJam2023MarsYeah.Actions;

public class Protest : Action
{
	private const string Title = "Organize a protest";
	private new const string FlavourText = "Organize a protest to raise awareness of the plight of the humans";

	public Protest() : base(Title, FlavourText)
	{
	}

	public override int GetPopularityEffect(GameState state) => 0;

	public override int GetDamage(GameState state) => 10;

	public override bool CanBeUsed(GameState state) => !state.IsHumanTurn && state.Opinion > 25;

	public override int GetProbability(GameState state) => 2;

	//TODO Add status effect
}