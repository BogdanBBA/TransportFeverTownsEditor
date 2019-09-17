using System.Drawing;
using System.Text.RegularExpressions;

namespace TransportFeverTownsEditor.Classes
{
	public class Town
	{
		public const string LINE_REGEX = @"{ ?pos ?= ?{ ?([\-\d\.]+), ?([\-\d\.]+) ?}, ?name ?= ?_\( ?""(.+?)"" ?\), ?sizeFactor ?= ?([\d\.]+) ?},";

		public string OriginalInput { get; private set; }
		public Coord Position { get; private set; }
		public string Name { get; private set; }
		public float SizeFactor { get; internal set; }

		public Town(string luaLine)
		{
			OriginalInput = luaLine;

			Match match = Regex.Match(luaLine, LINE_REGEX);
			Position = new Coord(double.Parse(match.Groups[1].Value), double.Parse(match.Groups[2].Value));
			Name = match.Groups[3].Value;
			SizeFactor = float.Parse(match.Groups[4].Value);
		}

		public bool HasChanged
			=> !OriginalInput.Equals(ToLuaLine());

		public string ToLuaLine()
			=> $"  {{pos = {{ {Position.X}, {Position.Y} }}, name = _(\"{Name}\"), sizeFactor = {SizeFactor}}},";

		public override string ToString()
			=> $"Town{{{Name}, ({Position.X}, {Position.Y}), {SizeFactor:F1} }}";
	}
}
