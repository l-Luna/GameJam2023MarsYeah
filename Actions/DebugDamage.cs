namespace GameJam2023MarsYeah.Actions;

public class DebugDamage : Action{

	public DebugDamage() : base("Debug Damage", "Hurt your opponent with the power of Exceptions"){}

	public override int GetPopularityEffect(GameState state) => 0;

	public override int GetDamage(GameState state) => 20;

	public override bool CanBeUsed(GameState state) => true;

	public override float GetProbability(GameState state) => 1;
}