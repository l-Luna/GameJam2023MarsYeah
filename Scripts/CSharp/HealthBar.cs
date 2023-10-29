using System;
using Godot;

namespace GameJam2023MarsYeah.Scripts.CSharp;

public enum HealthBarType
{
	Human,
	Martian
}

public partial class HealthBar : Control
{
	private GameState _state;
	private TextureProgressBar _bar;
	private RichTextLabel _label;

	[Export] public HealthBarType Type;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_state = GetNode<GameState>("/root/GameState");
		_bar = GetNode<TextureProgressBar>("./Health");
		_label = GetNode<RichTextLabel>("./Label");
		SetText();
		UpdateBar();
		_state.OnActionChosen += UpdateBar;
	}

	public override void _ExitTree(){
		base._ExitTree();
		_state.OnActionChosen -= UpdateBar;
	}

	private void UpdateBar()
	{
		_bar.Value = Type switch
		{
			HealthBarType.Human => _state.HumanHealth,
			HealthBarType.Martian => _state.MartianHealth,
			_ => throw InvalidHealthBarError()
		};
	}

	private void SetText()
	{
		string labelText = Type switch
		{
			HealthBarType.Human => "Humans",
			HealthBarType.Martian => "Martians",
			_ => throw InvalidHealthBarError()
		};
		_label.Text = "[center]" + labelText + "[/center]";
	}

	private static Exception InvalidHealthBarError() =>
		new ArgumentOutOfRangeException($"Unknown health bar type (how did you even do this?)");
}
