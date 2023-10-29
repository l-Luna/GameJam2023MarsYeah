namespace GameJam2023MarsYeah.Actions;

public abstract class Action{

	public abstract void OnSelect(GameState state);

	public abstract int PopularityEffect();

	public abstract int Damage();

	public abstract bool CanUse(GameState state);

	public abstract float Probability(GameState state);
}