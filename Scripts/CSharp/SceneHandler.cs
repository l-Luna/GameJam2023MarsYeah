using Godot;

namespace GameJam2023MarsYeah.Scripts.CSharp;

public partial class SceneHandler : Node{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready(){
		var mainMenu = GetNode<Control>("Main Menu");
		var playButton = mainMenu.GetNode<Button>("VBoxContainer/Buttons/PlayButton");
		playButton.Pressed += () => ToGame(mainMenu);
	}

	public void ToMainMenu(Node from){
		from.QueueFree();
		var scene = GD.Load<PackedScene>("res://Scenes/main_menu.tscn").Instantiate();
		AddChild(scene);

		GetNode("/root/AudioController").Call("to_menu_theme");
	}

	public void ToGameWon(Node from, bool humansWon){
		from.QueueFree();
		var gameEndScene = GD.Load<PackedScene>("res://Scenes/game_won.tscn").Instantiate();
		gameEndScene.Call("set_player_won", humansWon ? "Humans" : "Martians");
		AddChild(gameEndScene);

		GetNode("/root/AudioController").Call("to_menu_theme");
	}

	public void ToGame(Node from){
		from.QueueFree();
		var scene = GD.Load<PackedScene>("res://Scenes/game_handler.tscn").Instantiate();
		scene.AddToGroup("GameHandler");
		AddChild(scene);

		GetNode("/root/AudioController").Call("to_human_theme");
	}

	public void ToIntro(Node from){
		from.QueueFree();
		var scene = GD.Load<PackedScene>("res://Scenes/introduction_scene.tscn").Instantiate();
		AddChild(scene);
	}
}
