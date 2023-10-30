namespace GameJam2023MarsYeah.Actions;

public class Education : Action
{
	private const string Title = "Martian education campaign";
	private new const string FlavourText = "Educate the human public on Martian biology and culture";

	public Education() : base(Title, FlavourText)
	{
	}

	public override int GetPopularityEffect(GameState state) => 25;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => !state.IsHumanTurn;

	public override int GetProbability(GameState state) => 1;
}