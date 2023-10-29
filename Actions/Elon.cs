namespace GameJam2023MarsYeah.Actions;

public class Elon : Action {
	public Elon() : base("Deploy Elon v4.2.3", "Don't let the Martians have the monopoly on memes! Task the uploaded consciousness of Elon Musk with ") {}
	public override int GetPopularityEffect(GameState state) => -30;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) =>
		state.IsHumanTurn && state.ActionUsed(typeof(Education));

	public override int GetProbability(GameState state) => 1;
}