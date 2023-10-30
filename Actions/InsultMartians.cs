namespace GameJam2023MarsYeah.Actions;

public class InsultMartians : Action
{
	private const string Title = "Insult martian leaders";
	private const string Flavour = "The Martians don't even have hair. How bad is THAT?";

	public InsultMartians() : base(Title, Flavour)
	{
	}

	public override int GetPopularityEffect(GameState state) => 10;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => state.IsHumanTurn &&
	                                                   !state.ActionUsed(typeof(InsultMartians)) &&
	                                                   state.ActionUsed(typeof(InsultHumans));

	public override int GetProbability(GameState state) => 1;
}