namespace GameJam2023MarsYeah.Statuses;

public class Protesting : Status
{
	public Protesting() : base("Protests raging", "Ah. A large proportion of Earth's population appears to be protesting against our colonisation mission. That's not good for business.") {}

	protected override bool AffectsHumans()
	{
		return true;
	}

	protected override int GetDamage()
	{
		return 10;
	}
}