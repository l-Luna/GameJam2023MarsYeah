namespace GameJam2023MarsYeah.Actions;

public class Elon : Action
{
	private const string Title = "Deploy Elon v4.2.3";

	private const string Flavour =
		"Don't let the Martians have a monopoly on memes! Task the uploaded consciousness of Elon Moosk with making some dank memes";

	public Elon() : base(Title, Flavour)
	{
	}

	public override int GetPopularityEffect(GameState state) => state.Rng.Randf() >= 0.5 ? -40 : 40;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) =>
		state.IsHumanTurn && !state.ActionUsed(typeof(Elon)) && state.ActionUsed(typeof(Memes));

	public override int GetProbability(GameState state) => 10;
}