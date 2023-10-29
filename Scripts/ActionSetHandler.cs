using System.Collections.Generic;
using GameJam2023MarsYeah.Actions;
using Godot;

namespace GameJam2023MarsYeah.Scripts;

public partial class ActionSetHandler : Node{

	[Export]
	public bool IsHumanSide;

	private readonly List<Button> ActionButtons = new();

	public override void _Ready(){
		base._Ready();
		RefreshActions();
	}

	public void RemoveButtons(){
		foreach(Button b in ActionButtons)
			b.QueueFree();
		ActionButtons.Clear();
	}

	public void RefreshActions(){
		GD.Print("refreshing action buttons");
		// fetch game state
		GameState state = GetNode<GameState>("/root/GameState");
		// remove existing ones
		RemoveButtons();
		// find new actions
		List<Action> actions = ActionManager.GetValidActions(state, 3);
		// create buttons for each of them
		for(var idx = 0; idx < actions.Count; idx++){
			var a = actions[idx];
			Button b = new Button();
			b.Text = a.TitleText;
			b.Position = new Vector2(IsHumanSide ? -3000 : 3000, 12);
			b.ButtonDown += () => {
				a.OnSelect(state);
				state.InvokeActionChosen();
				state.IsHumanTurn = !IsHumanSide;
				RemoveButtons();
				SetFlavourText("");
				// enable other buttons
				foreach(Node actionSets in GetTree().GetNodesInGroup("ActionSet"))
					if(actionSets != this)
						actionSets.Call("RefreshActions");
				// camera pan
				GetTree().CallGroup("GameHandler", "pan_camera");
			};
			b.MouseEntered += () => SetFlavourText(a.FlavourText);
			Tween fanOut = GetTree().CreateTween().SetTrans(Tween.TransitionType.Sine);
			fanOut.TweenInterval(0.3f * idx);
			fanOut.TweenProperty(b, "position", new Vector2(10, 10 + 50 * idx), 0.5f);
			AddChild(b);
			ActionButtons.Add(b);
		}
	}

	private void SetFlavourText(string text){
		if(GetTree().GetFirstNodeInGroup("FlavourLabel") is Label label)
			label.Text = text;
	}
}