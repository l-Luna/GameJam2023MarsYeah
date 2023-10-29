namespace GameJam2023MarsYeah.Actions;

public class Memes : Action {
	public Memes() : base("Weaponised memes", "Appeal to the younger human demographic and post memes insulting Earth leaders.") {}
	public override int GetPopularityEffect(GameState state) => 15;

	public override int GetDamage(GameState state) => 1;

	public override bool CanBeUsed(GameState state) => !state.IsHumanTurn;

	public override float GetProbability(GameState state) => 1;
}