using Godot;

namespace GameJam2023MarsYeah.Helper;

public static class Helper
{
    public static Vector2 ScaleVector2(Vector2 v, float a) => new(v.X * a, v.Y * a);
}