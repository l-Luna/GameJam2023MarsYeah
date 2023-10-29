namespace GameJam2023MarsYeah.Statuses;

public class Greenhouse : Status
{
	public Greenhouse() : base("Greenhouse effect", "Greenhouse gases are causing the planet's temperature to rise!") {}

	protected override bool AffectsHumans()
	{
		return false;
	}

	protected override int GetDamage()
	{
		return 5;
	}
}