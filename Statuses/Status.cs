namespace GameJam2023MarsYeah.Statuses;

public abstract class Status
{
	public string TitleText { get; private set; }
	public string FlavourText;

	protected Status(string title, string flavourText)
	{
		TitleText = title;
		FlavourText = flavourText;
	}

	protected abstract bool AffectsHumans();

	public void Apply(GameState state)
	{
		if (state.IsHumanTurn && !AffectsHumans()) state.MartianHealth -= GetDamage();
		if (!state.IsHumanTurn && AffectsHumans()) state.HumanHealth -= GetDamage();
	}

	protected abstract int GetDamage();
}