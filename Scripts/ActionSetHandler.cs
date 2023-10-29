using System.Collections.Generic;
using GameJam2023MarsYeah.Actions;
using Godot;

namespace GameJam2023MarsYeah.Scripts;

public partial class ActionSetHandler : Node{

	private List<Button> ActionButtons = new();

	private void RefreshActions(){
		GD.Print("refreshing action buttons");
		// fetch game state
		GameState state = GetNode<GameState>("/root/GameState");
		// remove existing ones
		foreach(Button b in ActionButtons)
			b.QueueFree();
		ActionButtons.Clear();
		// find new actions
		List<Action> actions = ActionManager.GetValidActions(state, 3);
		// create buttons for each of them
		for(var idx = 0; idx < actions.Count; idx++){
			var a = actions[idx];
			Button b = new Button();
			b.Text = a.ActionText;
			b.Position = new Vector2(10, 10 + 50 * idx);
			b.ButtonDown += () => {
				a.OnSelect(state);
				state.IsHumanTurn = !state.IsHumanTurn;
				RefreshActions();
			};
			AddChild(b);
			ActionButtons.Add(b);
		}
	}
}
