using Godot;

namespace GameJam2023MarsYeah.Scripts.CSharp;

public partial class QuitButton : Button
{
	private void _OnPressed()
	{
		GetTree().Quit();
	}
}
