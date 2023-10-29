using Godot;

namespace GameJam2023MarsYeah;

public class GameState : Node{

	public int HumanHealth, MartianHealth, Opinion;

	public bool IsHumanTurn;

	public RandomNumberGenerator Rng;
	
	public override void _Ready(){
		base._Ready();
		HumanHealth = MartianHealth = 100;
		Opinion = -100;
		IsHumanTurn = true;
		// TODO: expose seed through UI
		Rng = new RandomNumberGenerator();
		Rng.Randomize();
	}
}