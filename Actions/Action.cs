using Godot;

namespace GameJam2023MarsYeah.Actions;

public abstract class Action
{
	public string ActionText { get; private set; }

	protected Action(string filename)
	{
		ActionText = FileAccess.GetFileAsString(filename);
	}

	public abstract void OnSelect(GameState state);

	public abstract int GetPopularityEffect(GameState state);

	public abstract int GetDamage(GameState state);

	public abstract bool CanBeUsed(GameState state);

	public abstract float GetProbability(GameState state);
}