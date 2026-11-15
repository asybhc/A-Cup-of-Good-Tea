using System.Drawing;

namespace B
{
	public enum Y
	{
		A,
		a
	}
	public enum y
	{
		A,
		a,
		B
	}
}
namespace b
{
	public sealed class Y
	{
		public Color A;

		public Color a;

		public Color B;

		public Color b;

		public Color C;

		public Color c;

		public Color D;

		public Color d;

		public Color E;

		public Color e;

		public Color F;

		public Color f;

		public Color G;

		public Color g;

		public Color H;

		public Color h;

		public Color I;

		public Color i;

		public Color J;

		public Color j;

		public bool IsDark => A.GetBrightness() < 0.5f;

		public static Y A_m_1()
		{
			return new Y
			{
				A = Color.FromArgb(246, 241, 234),
				a = Color.White,
				B = Color.FromArgb(223, 211, 198),
				b = Color.FromArgb(51, 38, 29),
				C = Color.FromArgb(36, 26, 19),
				c = Color.White,
				D = Color.FromArgb(51, 38, 29),
				d = Color.FromArgb(90, 74, 62),
				E = Color.FromArgb(242, 232, 222),
				e = Color.FromArgb(51, 38, 29),
				F = Color.FromArgb(232, 217, 203),
				f = Color.FromArgb(180, 69, 31),
				G = Color.White,
				g = Color.FromArgb(156, 59, 26),
				H = Color.FromArgb(252, 250, 247),
				h = Color.FromArgb(74, 59, 49),
				I = Color.FromArgb(107, 90, 78),
				i = Color.FromArgb(138, 90, 11),
				J = Color.FromArgb(163, 33, 27),
				j = Color.FromArgb(30, 107, 58)
			};
		}

		public static Y a_m_1()
		{
			return new Y
			{
				A = Color.FromArgb(25, 21, 18),
				a = Color.FromArgb(36, 31, 26),
				B = Color.FromArgb(74, 62, 52),
				b = Color.FromArgb(237, 228, 218),
				C = Color.White,
				c = Color.FromArgb(44, 37, 31),
				D = Color.FromArgb(240, 231, 221),
				d = Color.FromArgb(138, 119, 106),
				E = Color.FromArgb(47, 40, 34),
				e = Color.FromArgb(237, 228, 218),
				F = Color.FromArgb(61, 52, 44),
				f = Color.FromArgb(192, 82, 41),
				G = Color.White,
				g = Color.FromArgb(217, 102, 58),
				H = Color.FromArgb(31, 26, 22),
				h = Color.FromArgb(207, 195, 182),
				I = Color.FromArgb(185, 170, 156),
				i = Color.FromArgb(240, 184, 96),
				J = Color.FromArgb(255, 142, 128),
				j = Color.FromArgb(127, 215, 154)
			};
		}
	}
	public enum y
	{
		A,
		a,
		B
	}
}
