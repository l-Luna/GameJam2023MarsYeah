using Godot;

namespace GameJam2023MarsYeah.Scripts.CSharp;

public partial class OpinionBar : Control
{
	private GameState _state;
	private TextureProgressBar _humanBar;
	private TextureProgressBar _martianBar;
	private RichTextLabel _label;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_state = GetNode<GameState>("/root/GameState");
		_humanBar = GetNode<TextureProgressBar>("Bars/Humans");
		_martianBar = GetNode<TextureProgressBar>("Bars/Martians");
		UpdateBar();
		_state.OnActionChosen += _ => UpdateBar();
	}

	private void UpdateBar()
	{
		_humanBar.Value = GetHumanOpinion();
		_martianBar.Value = GetMartianOpinion();
	}

	private double GetHumanOpinion() => _state.Opinion < 0 ? -_state.Opinion : 0;

	private double GetMartianOpinion() => _state.Opinion > 0 ? _state.Opinion : 0;
}
