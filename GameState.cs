using Godot;

namespace GameJam2023MarsYeah;

public partial class GameState : Node{

	[Export]
	public int HumanHealth = 100, MartianHealth = 100, Opinion = -100;

	[Export]
	public bool IsHumanTurn = true;

	public RandomNumberGenerator Rng;

	public override void _Ready(){
		base._Ready();
		// TODO: expose seed through UI
		Rng = new RandomNumberGenerator();
		Rng.Randomize();
	}

	[Signal]
	public delegate void ActionChosenEventHandler();
	public event ActionChosenEventHandler OnActionChosen;

	public void InvokeActionChosen() => OnActionChosen?.Invoke();
}
