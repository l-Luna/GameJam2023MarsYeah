﻿namespace GameJam2023MarsYeah.Actions;

public abstract class Action{

	public string ActionText { get; private set; }

	protected Action(string filename){
		ActionText = filename; // for now
	}

	public virtual void OnSelect(GameState state){
		if(state.IsHumanTurn){
			state.MartianHealth -= GetDamage(state);
			state.Opinion -= GetPopularityEffect(state);
		}else{
			state.HumanHealth -= GetDamage(state);
			state.Opinion += GetPopularityEffect(state);
		}
	}

	public abstract int GetPopularityEffect(GameState state);

	public abstract int GetDamage(GameState state);

	public abstract bool CanBeUsed(GameState state);

	public abstract float GetProbability(GameState state);
}