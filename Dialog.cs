using System.Collections.Generic;
using System.Linq;
using Godot;

namespace GameJam2023MarsYeah;

public static class Dialog{
	
	private static Dictionary<string, string> Text = new();

	public static void Setup(string language = "English") =>
		// get the appropriate language file
		Text = FileAccess.GetFileAsString($"res://Dialog/{language}.txt")
			// look at it line-by-line
			.Split("\n")
			// ignore lines starting with # (comments)
			.Where(x => !x.StartsWith("#"))
			// split them by key/value
			.Select(x => x.Split("="))
			// put them in an actual dictionary for lookup
			.ToDictionary(x => x[0].Trim(), x => x[1].Trim());

	public static string Get(string key) =>
		Text.TryGetValue(key, out string value) ? value : $"{{{key}}}";
}