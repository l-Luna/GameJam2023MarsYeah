namespace GameJam2023MarsYeah.Actions;

public class InsultOpponent : Action{
	
	public override void OnSelect(GameState state){}

	public override int PopularityEffect() => 10;

	public override int Damage() => 0;

	public override bool CanUse(GameState state) => true;

	public override float Probability(GameState state) => 1;
}