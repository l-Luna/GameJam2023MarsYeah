using GameJam2023MarsYeah.Scripts.CSharp;
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

	public void Reset(){
		HumanHealth = MartianHealth = 100;
		Opinion = -100;
	}

	public event System.Action OnActionChosen;

	public void InvokeActionChosen(){
		// if we're about to win, jump to the game over menu
		if(HumanHealth == 0 || MartianHealth == 0){
			if(GetNode("/root/Scene Handler") is SceneHandler sc)
				sc.ToGameWon(GetNode("/root/Scene Handler/Game Handler"), MartianHealth == 0);
			Reset();
		}else
			OnActionChosen?.Invoke();
	}
}
