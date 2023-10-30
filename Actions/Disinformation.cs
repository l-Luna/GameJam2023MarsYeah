namespace GameJam2023MarsYeah.Actions;

public class Disinformation : Action{
	private const string Title = "Disinformation campaign";
	private new const string FlavourText = "Spread misinformation and harm your opponents reputation";

	public Disinformation() : base(Title, FlavourText){}

	public override int GetPopularityEffect(GameState state) => 20;

	public override int GetDamage(GameState state) => 0;

	public override bool CanBeUsed(GameState state) => true;

	public override int GetProbability(GameState state) => 1;
}