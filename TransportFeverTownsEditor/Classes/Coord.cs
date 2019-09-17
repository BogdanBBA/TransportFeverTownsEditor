using System.Drawing;

namespace TransportFeverTownsEditor.Classes
{
	public class Coord
	{
		public double X { get; private set; }
		public double Y { get; private set; }

		public Coord()
			: this(0.0, 0.0)
		{
		}

		public Coord(double x, double y)
		{
			X = x;
			Y = y;
		}

		public Point ToPoint()
		{
			return new Point((int)X, (int)Y);
		}

		public override string ToString()
			=> $"{X}, {Y}";
	}
}
