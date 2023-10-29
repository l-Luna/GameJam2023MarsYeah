namespace GameJam2023MarsYeah.Actions;

public abstract class Action{

	public abstract void OnSelect();

	public abstract int PopularityEffect();

	public abstract int Damage();

	public abstract int PopularityRequired();
}