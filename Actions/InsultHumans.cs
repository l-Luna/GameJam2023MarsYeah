namespace GameJam2023MarsYeah.Actions;

public class InsultHumans : Action
{
	private const string Title = "Insult human leaders";
	private new const string FlavourText = "The current SpaceY CEO is balding rapidly. Make sure the world knows";

	public InsultHumans() : base(Title, FlavourText)
	{
	}

	public override int GetPopularityEffect(GameState state) => 10;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => !state.IsHumanTurn && !state.ActionUsed(typeof(InsultHumans));

	public override int GetProbability(GameState state) => 1;
}