using Godot;

namespace GameJam2023MarsYeah.Scripts.CSharp;

public partial class SceneHandler : Node
{
	private Control _mainMenu;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_mainMenu = GetNode<Control>("Main Menu");
		var playButton = _mainMenu.GetNode<Button>("VBoxContainer/Buttons/PlayButton");
		playButton.Pressed += () =>
		{
			var scene = GD.Load<PackedScene>("res://Scenes/game_handler.tscn").Instantiate();
			AddChild(scene);
			_mainMenu.QueueFree();
			_mainMenu = null;
		};
	}
}
