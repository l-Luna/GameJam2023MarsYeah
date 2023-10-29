namespace GameJam2023MarsYeah.Actions;

public class InsultOpponent : Action{
	
	public override void OnSelect(){
		
	}

	public override int PopularityEffect() => 10;

	public override int Damage() => 0;

	public override int PopularityRequired() => -50;
}