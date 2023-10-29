using System.Buffers.Text;

namespace GameJam2023MarsYeah.Actions;

public class Education : Action {
	public Education() : base("Martian education campaign", "Educate the human public on Martian biology and culture.") {}
	public override int GetPopularityEffect(GameState state) => 15;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => !state.IsHumanTurn;

	public override int GetProbability(GameState state) => 1;
}