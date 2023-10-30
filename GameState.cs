using System;
using System.Collections.Generic;
using GameJam2023MarsYeah.Scripts.CSharp;
using Godot;
using Action = GameJam2023MarsYeah.Actions.Action;

namespace GameJam2023MarsYeah;

public partial class GameState : Node{

	[Export]
	public int HumanHealth = 100, MartianHealth = 100, Opinion = -100;

	[Export]
	public bool IsHumanTurn = true;

	private HashSet<Type> _usedActions = new();

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
		_usedActions.Clear();
	}

	public event System.Action OnActionChosen;

	public void InvokeActionChosen(Action action){
		// if we're about to win, jump to the game over menu
		if(HumanHealth == 0 || MartianHealth == 0){
			if(GetNode("/root/Scene Handler") is SceneHandler sc)
				sc.ToGameWon(GetNode("/root/Scene Handler/Game Handler"), MartianHealth == 0);
			Reset();
		}
		else
		{
			OnActionChosen?.Invoke();
			_usedActions.Add(action.GetType());
		}
	}

	public bool ActionUsed(Type t) => _usedActions.Contains(t);
}
