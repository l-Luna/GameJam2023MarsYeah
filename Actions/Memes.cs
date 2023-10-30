namespace GameJam2023MarsYeah.Actions;

public class Memes : Action
{
	private const string Title = "Weaponised memes";
	private const string Flavour = "Appeal to the younger human demographic and post memes insulting Earth leaders";

	public Memes() : base(Title, Flavour)
	{
	}

	public override int GetPopularityEffect(GameState state) => 15;

	public override int GetDamage(GameState state) => 1;

	public override bool CanBeUsed(GameState state) => !state.IsHumanTurn;

	public override int GetProbability(GameState state) => 1;
}